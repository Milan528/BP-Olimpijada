using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;

namespace Olimpijada
{
    public partial class DodajTakmicenje : Form
    {
        public DodajTakmicenje()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Olimpijada.Entiteti.Takmicenje p = new Olimpijada.Entiteti.Takmicenje();


                p.NazivStadiona = textBoxNaziv.Text;
                p.VremeOdrzavanja = textBoxVreme.Text;
                p.DatumOdrzavanja = dateTimePicker1.Value;


                Console.WriteLine("Dodato");
                s.Save(p);
                s.Flush();
                s.Close();



               // MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show("Podaci nisu ispravno uneti");
            }
            this.Close();
        }

        private void DodajTakmicenje_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVreme_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
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
