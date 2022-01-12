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
    public partial class DodajPostojecegSportistu : Form
    {
        int idTakmicenja;
        public DodajPostojecegSportistu(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }
        

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    int id = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                ISession s = DataLayer.GetSession();
                Sportista sportista = s.Load<Sportista>(id);
                List < UcestvujePregled > provera= UcestvujeManager.VratiUcestovanja(id, idTakmicenja);
                if (provera.Count == 0)
                {
                    Ucestvuje ucestvuje = new Ucestvuje();

                    Takmicenje takmicenje = s.Load<Takmicenje>(idTakmicenja);


                    ucestvuje.Medalja = null;
                    ucestvuje.Mesto = 0;
                    ucestvuje.IdSportiste = sportista;
                    ucestvuje.IdTakmicenja = takmicenje;

                    s.Save(ucestvuje);

                    /*  takmiciSe.IdSportiste = sportista;
                      s.Save(takmiciSe);*/

                    s.Flush();
                    s.Close();
                }
                }
                else
                    MessageBox.Show("Odaberite sportistu");

            }

            catch(Exception c)
            {
                //MessageBox.Show(c.Message);
                MessageBox.Show("Sportista vec ucestvuje na takmicenju");
            }

           
        }

        private void DodajPostojecegSportistu_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {

            listView1.Items.Clear();

            List<SportistaPregled> odInfos = SportistaManager.PrikaziSveSportiste();
            foreach (SportistaPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Zemlja, op.LicnoIme, op.Prezime, op.Inicijali, op.Id.ToString(), op.PredstavljaZemlju });

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


                Olimpijada.Entiteti.Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(Id);
               


                
                s.Delete(p);

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
    }
}
