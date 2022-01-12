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
    public partial class DodajSportiste : Form
    {
        int idTakmicenja;
        public DodajSportiste(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }
        DodajZemlju dodajZemlju;
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxZemlja.Text != null && textBoxLime.Text != null && textBoxLime.Text != null && textBoxPrezime.Text != null && textBoxInicijali.Text != null && textBoxMesto.Text != null && comboBoxMedalja.SelectedIndex > -1)
                {
                    ISession s = DataLayer.GetSession();


                    Sportista p = new Sportista();
                    Ucestvuje u = new Ucestvuje();


                    IEnumerable<Zemlja> skracenice = from o in s.Query<Zemlja>()
                                                     where o.JedinstvenaSkracenica == textBoxPredstavlja.Text
                                                     select o;
                    Zemlja z;

                    if (skracenice.Count() == 0)
                    {
                        dodajZemlju = new DodajZemlju(textBoxPredstavlja.Text);
                        dodajZemlju.ShowDialog();
                        z = dodajZemlju.Zemlja;

                    }
                    else
                        z = s.Load<Zemlja>(textBoxPredstavlja.Text);

                    p.Zemlja = textBoxZemlja.Text;
                    p.LicnoIme = textBoxLime.Text;
                    p.Prezime = textBoxPrezime.Text;
                    p.Inicijali = textBoxInicijali.Text;
                    p.PredstavljaZemlju = z;
                    s.Save(p);

                    Takmicenje t = s.Load<Takmicenje>(idTakmicenja);
                    u.IdTakmicenja = t;
                    u.IdSportiste = p;

                    u.Mesto = int.Parse(textBoxMesto.Text);
                    if (comboBoxMedalja.SelectedItem.ToString() != "NIJE OSVOJENA")
                        u.Medalja = comboBoxMedalja.SelectedItem.ToString();




                    Console.WriteLine("Dodato");

                    s.Save(u);
                    s.Flush();
                    s.Close();
                    this.Close();
                }
                MessageBox.Show("Unesite sve podatke");

            }
            catch (Exception ec)
            {
                MessageBox.Show("Podaci nisu ispravno uneti");
            }
           
        }

        private void DodajSportiste_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
