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
    public partial class DodajPostojecegSudiju : Form
    {
        int idTakmicenja;
        public DodajPostojecegSudiju(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        private void DodajPostojecegSudiju_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView2.Items.Clear();
            List<SudijePregled> odInfos = SudijaManager.PrikaziSveSudije();
            foreach (SudijePregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Zemlja,op.LicnoIme,op.Prezime,op.Id.ToString(),op.Specijalnost });

                listView2.Items.Add(item);
            }
            listView2.Refresh();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listView2.SelectedItems[0].SubItems[3].Text);

                ISession s = DataLayer.GetSession();
                List<SudiNaPregled> provera = SudiNaManager.VratiSudiNa(id, idTakmicenja);
                if (provera.Count == 0)
                {
                    Sudija sudija = s.Load<Sudija>(id);
                    Takmicenje t = s.Load<Takmicenje>(idTakmicenja);
                    SudiNa sa = new SudiNa();
                    sa.Id.IdSudije = sudija;
                    sa.Id.IdTakmicenja = t;

                    s.Save(sa);
                    s.Flush();
                    s.Close();
                }
                else
                    MessageBox.Show("Sudija Vec sudi na takmicenju");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Odaberite sudiju");
            }


        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {

                int Id = int.Parse(listView2.SelectedItems[0].SubItems[3].Text);

                ISession s = DataLayer.GetSession();


                Olimpijada.Entiteti.Sudija p = s.Load<Olimpijada.Entiteti.Sudija>(Id);
                s.Delete(p);


                s.Flush();
                s.Close();
                MessageBox.Show("Izbrisano");
            }
            catch (Exception ec)
            {
                // MessageBox.Show(ec.Message);
                MessageBox.Show("Odaberite sudiju");
            }
            PopulateInfos();
        }
    }
}
