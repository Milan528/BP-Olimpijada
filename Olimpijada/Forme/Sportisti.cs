using NHibernate;
using NHibernate.Linq;
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
    public partial class Sportisti : Form
    {
        
        int idTakmicenja;
       
        public Sportisti(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        private void Sportisti_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
           
            List<SportistaPregled> odInfos = SportistaManager.PrikaziSportiste(idTakmicenja);
            foreach (SportistaPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] {  op.Zemlja, op.LicnoIme, op.Prezime,op.Inicijali, op.Id.ToString(), op.PredstavljaZemlju,op.Medalja,op.Mesto.ToString() });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {


                int Id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);

                ISession s = DataLayer.GetSession();



                List<UcestvujePregled> test = UcestvujeManager.VratiUcestovanja(Id, idTakmicenja);

                Ucestvuje u = new Ucestvuje();
                u.IdUcestvuje = test[0].ID;
                s.Delete(u);

                s.Flush();
                s.Close();
                MessageBox.Show("Izbrisano");
                }
                else
                    MessageBox.Show("Odaberite sportistu");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PopulateInfos();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajSportiste d = new DodajSportiste(idTakmicenja);
            d.ShowDialog();
            PopulateInfos();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

            string zemlja = listView1.SelectedItems[0].SubItems[0].Text;
            string licnoIme = listView1.SelectedItems[0].SubItems[1].Text;
            string prezime = listView1.SelectedItems[0].SubItems[2].Text;
            string inicijali = listView1.SelectedItems[0].SubItems[3].Text;
            int id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
            string predstavljaZemlju = listView1.SelectedItems[0].SubItems[5].Text;
            /*int mesto;
            int.TryParse((listView1.SelectedItems[0].SubItems[6].Text),out mesto);*/
            int mesto = int.Parse(listView1.SelectedItems[0].SubItems[7].Text);
            string medalja = listView1.SelectedItems[0].SubItems[6].Text;



            IzmeniSportiste d = new IzmeniSportiste(id,idTakmicenja, zemlja, licnoIme, prezime,inicijali,predstavljaZemlju,mesto,medalja);
            d.ShowDialog();
            PopulateInfos();
            }
            else
                MessageBox.Show("Odaberite sportistu");
            /*int id,string Zemlja,string LicnoIme,string Prezime,string Inicijali,string PredstavljaZemlju*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPostojecegSportistu dodajPostojeceg = new DodajPostojecegSportistu(idTakmicenja);
            dodajPostojeceg.ShowDialog();
            PopulateInfos();
        }
    }
}
