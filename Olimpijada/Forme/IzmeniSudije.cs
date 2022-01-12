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
    public partial class IzmeniSudije : Form
    {
        int id;
      
        public IzmeniSudije(string Zemlja,string LicnoIme,string Prezime,int ID,string Specijalnost)
        {
            InitializeComponent();
            textBoxZemlja.Text = Zemlja;
            textBoxLime.Text = LicnoIme;
            textBoxPrezime.Text = Prezime;
            textBoxSpecijalnost.Text = Specijalnost;
            this.id = ID;
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               
                Olimpijada.Entiteti.Sudija p = s.Load<Olimpijada.Entiteti.Sudija>(id);

               

                
                p.Zemlja = textBoxZemlja.Text;
                p.LicnoIme = textBoxLime.Text;
                p.Prezime = textBoxPrezime.Text;
                p.Specijalnost = textBoxSpecijalnost.Text;
               
               

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
    }
}
