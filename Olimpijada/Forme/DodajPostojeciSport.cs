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
    public partial class DodajPostojeciSport : Form
    {
        string tip;
        int idDiscipline;
        string tipSporta;
        public DodajPostojeciSport(int idDiscipline,string tip)
        {
            InitializeComponent();
            this.tip = tip;
            this.idDiscipline = idDiscipline;
            if (tip == "KOMBINOVANA")
                tipSporta = "Kombinovani";
            else if (tip == "EKIPNA")
                tipSporta = "Ekipni";
            else
                tipSporta = "Pojedinacni";
        }

        private void DodajPostojeciSport_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<SportPregled> odInfos = SportManager.PrikaziSportove(tipSporta);
            foreach (SportPregled op in odInfos)
            {
               
                    ListViewItem item = new ListViewItem(new string[] { op.BrojDiscipline.ToString(), op.TipSporta, op.Naziv, op.MSA, op.ID.ToString() });

                    listView1.Items.Add(item);
                
            }
            listView1.Refresh();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems != null)
                {
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                    ISession s = DataLayer.GetSession();
                    ImaDisciplinu nova = new ImaDisciplinu();
                    Disciplina d = s.Load<Disciplina>(idDiscipline);
                    Sport sport = s.Load<Sport>(id);
                    nova.Id.IdSporta = sport;
                    nova.Id.SifraDiscipline = d;
                    s.Save(nova);
                    s.Flush();
                    s.Close();

                 }
                else
                    MessageBox.Show("Selektujte sport");
            

            }
            catch (Exception x)
            {
                //MessageBox.Show(x.Message);
                MessageBox.Show("Selektujte sport");
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems != null)
                {
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                    ISession s = DataLayer.GetSession();
                    Sport sport = s.Load<Sport>(id);
                   
                   
                   
                    s.Delete(sport);
                    s.Flush();
                    s.Close();

                }
                else
                    MessageBox.Show("Selektujte sport");


            }
            catch (Exception x)
            {
                MessageBox.Show("Selektujte sport");
            }
        }
    }
}
