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
    public partial class FormaSport : Form
    {
        int idDiscipline;
        string tip;
        public FormaSport(int idDiscipline,string tip)
        {
            InitializeComponent();
            this.idDiscipline = idDiscipline;
            this.tip = tip;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems != null)
                {
                    ISession s = DataLayer.GetSession();
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                    ImaDisciplinu disc = new ImaDisciplinu();
                    Disciplina d = s.Load<Disciplina>(idDiscipline);
                    Sport sport = s.Load<Sport>(id);
                    disc.Id.IdSporta = sport;

                    disc.Id.SifraDiscipline = d;
                    s.Delete(disc);
                    s.Flush();
                    s.Close();
                    PopulateInfos();
                }
                else
                    MessageBox.Show("Selektujte sport");
            }
            catch (Exception x)
            {
                MessageBox.Show("Selektujte sport");
            }
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<SportPregled> odInfos = SportManager.PrikaziSportove(idDiscipline);
            foreach (SportPregled op in odInfos)
            {

                ListViewItem item = new ListViewItem(new string[] { op.BrojDiscipline.ToString(),op.TipSporta,op.Naziv,op.MSA,op.ID.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void FormaSport_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                int brojDiscipline = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string naziv = listView1.SelectedItems[0].SubItems[2].Text;
                string msa = listView1.SelectedItems[0].SubItems[3].Text;
                IzmeniSport izmeni = new IzmeniSport(id, brojDiscipline, naziv, msa);
                izmeni.ShowDialog();
                PopulateInfos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Selektujte sport");
            }
        }

        private void buttonDodajPostojece_Click(object sender, EventArgs e)
        {
            DodajPostojeciSport sport = new DodajPostojeciSport(idDiscipline, tip);
            sport.ShowDialog();
            PopulateInfos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DodajSport dodajSport = new DodajSport(idDiscipline, tip);
            dodajSport.ShowDialog();
            PopulateInfos();
        }
    }
}
