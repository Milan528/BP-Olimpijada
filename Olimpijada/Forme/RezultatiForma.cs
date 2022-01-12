using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Olimpijada.Entiteti;
using Olimpijada.Forme;

namespace Olimpijada
{
    public partial class RezultatiForma : Form
    {
        int idDiscipline;
        public RezultatiForma(int idDiscipline)
        {
            InitializeComponent();
            this.idDiscipline = idDiscipline;
        }

        
       

        private void RezultatiForma_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<RezultatiPregled> odInfos = RezultatiManager.PrikaziRezultate(idDiscipline);
            foreach (RezultatiPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Id.ToString(),op.SifraDiscipline.ToString(),op.SkracenicaZemlje,op.DatumPostizanja,op.RezultatZemlje.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                ISession s = DataLayer.GetSession();

                OstvarenRezultat t = s.Load<OstvarenRezultat>(id);
                s.Delete(t);
                s.Flush();
                s.Close();
                PopulateInfos();
            }
            catch (Exception x)
            {
                // MessageBox.Show(x.Message);
                MessageBox.Show("Niste odabrali rezultat");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                double rezultat = double.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                DateTime datum = DateTime.Parse(listView1.SelectedItems[0].SubItems[3].Text);
                IzmeniRezultat t = new IzmeniRezultat(id,rezultat,datum);
                t.ShowDialog();
                PopulateInfos();
            }
            catch (Exception x)
            {
                MessageBox.Show("Niste odabrali rezultat");

            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajOstvarenRezultat rez = new DodajOstvarenRezultat(idDiscipline);
            rez.ShowDialog();
            PopulateInfos();

        }
    }
}
