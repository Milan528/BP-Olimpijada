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
    public partial class IzmeniTakmicenje : Form
    {
        int id;

        public IzmeniTakmicenje(int id, string nazivStadiona, string vremeOdrzavanja, DateTime dateTime)
        {
            InitializeComponent();
            textBoxNaziv.Text = nazivStadiona;
            textBoxVreme.Text = vremeOdrzavanja;
            dateTimePicker1.Value = dateTime;
            this.id = id;
        }

        private void IzmeniTakmicenje_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Takmicenje p = s.Load<Olimpijada.Entiteti.Takmicenje>(id);

               
                p.NazivStadiona = textBoxNaziv.Text;
                p.VremeOdrzavanja = textBoxVreme.Text;
                p.DatumOdrzavanja = dateTimePicker1.Value;
             
                

                s.Update(p);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("Podaci nisu ispravno uneti");
            }
            this.Close();
        }
    }
}
