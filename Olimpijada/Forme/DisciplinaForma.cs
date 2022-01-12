using NHibernate;
using Olimpijada.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Olimpijada
{
    public partial class DisciplinaForma : Form
    {
        int idTakmicenja;
        
        // int idDiscipline;
        public DisciplinaForma(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        public DisciplinaForma()
        {
        }

        private void DisciplinaForma_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<DisciplinePregled> odInfos = DisciplineManager.PrikaziDiscipline(idTakmicenja);
            foreach (DisciplinePregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Id.ToString(), op.Ime, op.Tip, op.SvetskiRekord.ToString(), op.OlimpijskiRekord.ToString(), op.ProslogodisnjiRezultat.ToString(), op.SvetskiSampion, op.OlimpijskiSampion });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int idDiscipline = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            RezultatiForma rezultatiForma = new RezultatiForma(idDiscipline);
            rezultatiForma.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite disciplinu");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajDisciplinu dodajDisciplinu = new DodajDisciplinu(idTakmicenja);
            dodajDisciplinu.ShowDialog();
            PopulateInfos();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {

                int Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                ISession s = DataLayer.GetSession();


                Takmicenje t = s.Load<Takmicenje>(idTakmicenja);
                Disciplina d = s.Load<Disciplina>(Id);
                OdrzavaSe odrzavaSe = new OdrzavaSe();
                odrzavaSe.OdrzavaSeId.IdDiscipline = d;
                odrzavaSe.OdrzavaSeId.IdTakmicenje = t;

                s.Delete(odrzavaSe);
                s.Flush();
                s.Close();
            }/*
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }*/
            catch (Exception)
            {
                MessageBox.Show("Odaberite disciplinu");
            }
            PopulateInfos();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try { 
            int Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);


            string ime = listView1.SelectedItems[0].SubItems[1].Text;
            string tip = listView1.SelectedItems[0].SubItems[2].Text;
            string svetskiRekord = listView1.SelectedItems[0].SubItems[3].Text;
            string olimpijskiRekord = listView1.SelectedItems[0].SubItems[4].Text;
            string proslogodisnjiRezultat = listView1.SelectedItems[0].SubItems[5].Text;
            string svetskiSampion = listView1.SelectedItems[0].SubItems[6].Text;
            string olimpijskiSampion = listView1.SelectedItems[0].SubItems[7].Text;

            IzmeniDisciplinu d = new IzmeniDisciplinu(Id, ime, tip, svetskiRekord, olimpijskiRekord, proslogodisnjiRezultat, svetskiSampion, olimpijskiSampion);
            d.ShowDialog();
            PopulateInfos();
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite disciplinu");
            }
        }

        private void buttonSportisti_Click(object sender, EventArgs e)
        {
            try
            {
                int idDiscipline = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                SportistiTakmiciSe discipline = new SportistiTakmiciSe(idDiscipline, idTakmicenja);
                discipline.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite disciplinu");
            }
        }

        private void buttonPostojece_Click(object sender, EventArgs e)
        {
            DodajPostojecuDisciplinu dodaj = new DodajPostojecuDisciplinu(idTakmicenja);
            dodaj.ShowDialog();
            PopulateInfos();
        }

        private void buttonSport_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                int idDiscipline = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string tip = listView1.SelectedItems[0].SubItems[2].Text;
                FormaSport formaSport = new FormaSport(idDiscipline,tip);
                formaSport.ShowDialog();
            }
            else
                MessageBox.Show("Niste selektovali disciplinu");
        }
    }
}
