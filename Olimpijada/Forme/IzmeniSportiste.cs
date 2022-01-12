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
using NHibernate.Linq;

namespace Olimpijada
{
    public partial class IzmeniSportiste : Form
    {
        int idsportiste;
        int idTakmicenja;

        public IzmeniSportiste(int idsportiste,int idTakmicenja,string Zemlja,string LicnoIme,string Prezime,string Inicijali,string PredstavljaZemlju,int mesto,string medalja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
            textBoxZemlja.Text = Zemlja;
            textBoxLime.Text = LicnoIme;
            textBoxPrezime.Text = Prezime;
            textBoxInicijali.Text = Inicijali;
            textBoxPredstavlja.Text = PredstavljaZemlju;
            this.idsportiste = idsportiste;
            textBoxMesto.Text = mesto.ToString();
            comboBoxMedalja.SelectedIndex = comboBoxMedalja.FindStringExact(medalja);
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o disciplini za zadatim brojem
                Olimpijada.Entiteti.Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(idsportiste);
                IEnumerable<Ucestvuje> ucestvujes = from o in s.Query<Ucestvuje>()
                                                    where (o.IdTakmicenja.ID==idTakmicenja && o.IdSportiste.IdSportista==idsportiste)
                                                    select o;

                Ucestvuje u = ucestvujes.First();
                

                /*p.NazivStadiona = textBoxNaziv.Text;
                p.VremeOdrzavanja = textBoxVreme.Text;
                p.DatumOdrzavanja = dateTimePicker1.Value;*/
                p.Zemlja = textBoxZemlja.Text;
                p.LicnoIme = textBoxLime.Text;
                p.Prezime = textBoxPrezime.Text;
                p.Inicijali = textBoxInicijali.Text;
                p.PredstavljaZemlju.Ime = textBoxPredstavlja.Text;
                u.Mesto = int.Parse(textBoxMesto.Text);
                if (comboBoxMedalja.SelectedItem.ToString() != "NIJE OSVOJENA")
                    u.Medalja = comboBoxMedalja.SelectedItem.ToString();
                else
                    u.Medalja = null;


                s.Update(p);
                s.Flush();
                s.Close();
                this.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("Podaci nisu ispravno uneti");
            }
            
        }
    

        private void IzmeniSportiste_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPredstavlja_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInicijali_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxZemlja_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

