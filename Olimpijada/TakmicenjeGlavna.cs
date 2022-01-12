using NHibernate;
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
    public partial class TakmicenjeGlavna : Form
    {
        public TakmicenjeGlavna()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {

        }

        private void TakmicenjeGlavna_Load(object sender, EventArgs e)
        {
            PopulateInfos();

        }
        public void PopulateInfos()
        {
            listView1.Items.Clear();
            List<TakmicenjaPregled> odInfos = TakmicenjaManager.PrikaziTakmicenja();
            foreach (TakmicenjaPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] {op.Id.ToString(), op.Naziv.ToString(), op.VremeOdrzavanja, op.DatumOdrzavanja.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajTakmicenje d = new DodajTakmicenje();
            d.ShowDialog();
            PopulateInfos();

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    int Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                ISession s = DataLayer.GetSession();


                Olimpijada.Entiteti.Takmicenje p = s.Load<Olimpijada.Entiteti.Takmicenje>(Id);
                s.Delete(p);

               // MessageBox.Show("Izbrisano");
                s.Flush();
                s.Close();
                }
                else
                    MessageBox.Show("Odaberite takmicenje");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PopulateInfos();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);


                string naziv = listView1.SelectedItems[0].SubItems[1].Text;
                string vreme = listView1.SelectedItems[0].SubItems[2].Text;
                DateTime datum = DateTime.Parse(listView1.SelectedItems[0].SubItems[3].Text);

                IzmeniTakmicenje d = new IzmeniTakmicenje(Id, naziv, vreme, datum);

                d.ShowDialog();
                PopulateInfos();
            }
            else
                MessageBox.Show("Odaberite takmicenje");

        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                int idTakmicenja = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                InfoTakmicenja info = new InfoTakmicenja(idTakmicenja);

                info.ShowDialog();
            }
            else
                MessageBox.Show("Odaberite takmicenje");
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
