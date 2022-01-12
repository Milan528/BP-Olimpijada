using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using Olimpijada.Entiteti;

namespace Olimpijada
{
    public partial class DodajZemlju : Form
    {
        private Zemlja zemlja;
        private string skracenica;
        public DodajZemlju(string skracenica)
        {
            InitializeComponent();
            zemlja = new Zemlja();
            this.skracenica = skracenica;
            zemlja.JedinstvenaSkracenica = skracenica;
            labelSkracenica.Text = skracenica;
        }

       
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (check())
            {
                zemlja.Ime = textBoxIme.Text;
                zemlja.Kontinent = textBoxKontinent.Text;
                DodajUBazu();
                this.Close();
            }
            else
                MessageBox.Show("Unesite sve podatke");

        }

        private void DodajUBazu()
        {
            ISession s = DataLayer.GetSession();

            s.Save(zemlja);
            s.Flush();
            s.Close();
            
        }

        private bool check()
        {
            if (textBoxIme.Text == "")
                return false;
            else if (textBoxKontinent.Text == "")
                return false;
            else
                return true;
        }
        public Zemlja Zemlja
        {
            get => this.zemlja;
            set => this.zemlja = value;
        }
    }
}
