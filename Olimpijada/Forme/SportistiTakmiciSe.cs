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
    public partial class SportistiTakmiciSe : Form
    {
        int idTakmicenja;
        int idDiscipline;
        public SportistiTakmiciSe(int idDiscipline,int idTakmicenja)
        {
            InitializeComponent();
            this.idDiscipline = idDiscipline;
            this.idTakmicenja = idTakmicenja;
        }

        private void SportistiDiscipline_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<TakmiciSePregled> odInfos = TakmiciSeManager.PrikaziTakmiciSe(idDiscipline);
            foreach (TakmiciSePregled p in odInfos)
            {
                ISession s = DataLayer.GetSession();
                Sportista op = s.Load<Sportista>(p.IdSportiste);
                ListViewItem item = new ListViewItem(new string[]
                {
                    op.Zemlja,op.LicnoIme,op.Prezime,op.Inicijali,op.IdSportista.ToString(),op.PredstavljaZemlju.Ime,p.LicniRekord.ToString(),p.Id.ToString()
                });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajTakmiciSe dodajTakmiciSe = new DodajTakmiciSe(idTakmicenja, idDiscipline);
            dodajTakmiciSe.ShowDialog();
            PopulateInfos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[7].Text);
                double licniRekord = double.Parse(listView1.SelectedItems[0].SubItems[6].Text);
                IzmeniTakmiciSe t = new IzmeniTakmiciSe(id, licniRekord);
                t.ShowDialog();
                PopulateInfos();
            }
            catch (Exception x)
            {
                // MessageBox.Show(x.Message);
                MessageBox.Show("Niste odabrali sportistu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[7].Text);
                ISession s = DataLayer.GetSession();

                TakmiciSe t = s.Load<TakmiciSe>(id);
                s.Delete(t);
                s.Flush();
                s.Close();
                PopulateInfos();
            }
            catch (Exception x)
            {
                // MessageBox.Show(x.Message);
                MessageBox.Show("Niste odabrali sportistu");
            }
               
        }
    }
}
