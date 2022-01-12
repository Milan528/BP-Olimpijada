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
    public partial class SudijeForma : Form
    {
        int idTakmicenja;
      
        public SudijeForma(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        public SudijeForma()
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SudijeForma_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        public void PopulateInfos()
        {
            listView1.Items.Clear();
            List<SudijePregled> odInfos = SudijaManager.PrikaziSudije(idTakmicenja);
            foreach (SudijePregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Zemlja, op.LicnoIme, op.Prezime, op.Id.ToString(),op.Specijalnost });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajSudije dodajSudije = new DodajSudije(idTakmicenja);
            dodajSudije.ShowDialog();
            PopulateInfos();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {

                int Id = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);

                ISession s = DataLayer.GetSession();

                Sudija sudija = s.Load<Sudija>(Id);
                Takmicenje t = s.Load<Takmicenje>(idTakmicenja);
                SudiNa p = new SudiNa();
                p.Id.IdSudije = sudija;
                p.Id.IdTakmicenja = t;
                s.Delete(p);

               
                s.Flush();
                s.Close();
                //MessageBox.Show("Izbrisano");
            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message);
                MessageBox.Show("Odaberite sudiju");
            }
            PopulateInfos();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string zemlja = listView1.SelectedItems[0].SubItems[0].Text;
                string licnoIme = listView1.SelectedItems[0].SubItems[1].Text;
                string prezime = listView1.SelectedItems[0].SubItems[2].Text;
                int id = int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
                string specijalnost = listView1.SelectedItems[0].SubItems[4].Text;

                IzmeniSudije izmeniSudije = new IzmeniSudije(zemlja, licnoIme, prezime, id, specijalnost);
                izmeniSudije.ShowDialog();
                PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Odaberite sudiju");
            }
           
        }

        private void buttonDodajPostojeceg_Click(object sender, EventArgs e)
        {
            DodajPostojecegSudiju dodajPostojeceg = new DodajPostojecegSudiju(idTakmicenja);
            dodajPostojeceg.ShowDialog();
            PopulateInfos();
        }
    }
}
