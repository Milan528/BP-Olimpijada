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
    public partial class DodajSudije : Form
    { 
        SudijeForma sudijeForma=new SudijeForma();
        int idTakmicenje;
        public DodajSudije(int idTakmicenje)
        {
            InitializeComponent();
            this.idTakmicenje = idTakmicenje;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Olimpijada.Entiteti.Sudija p = new Olimpijada.Entiteti.Sudija();

                //Zemlja z = s.Load<Zemlja>(textBoxSKR.Text);


                p.Zemlja = textBoxZemlja.Text;
                p.LicnoIme = textBoxLime.Text;
                p.Prezime = textBoxPrezime.Text;
                p.Specijalnost = textBoxSpecijalnost.Text;
               // p.PredstavljaZemlju = z;


                Console.WriteLine("Dodato");
                s.Save(p);
                //sudijeForma.PopulateInfos();

                SudiNa sa = new SudiNa();
                sa.Id.IdSudije = p;
                Takmicenje t = s.Load<Takmicenje>(idTakmicenje);
                sa.Id.IdTakmicenja = t;
                s.Save(sa);
                s.Flush();
                s.Close();



                // MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show("Niste uneli podatke");
            }
            this.Close();
        }
    }
    }

