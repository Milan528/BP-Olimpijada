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
    public partial class IzmeniSport : Form
    {
        int idSporta;
        public IzmeniSport(int idSporta,int brojDiscipline,string naziv,string msa)
        {
            InitializeComponent();
            this.idSporta = idSporta;
            textBoxDisciplina.Text = brojDiscipline.ToString();
            textBoxNaziv.Text = naziv;
            textBoxMSA.Text = msa;
                
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void IzmeniSport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               
                Olimpijada.Entiteti.Sport p = s.Load<Olimpijada.Entiteti.Sport>(idSporta);



                p.BrojDiscipline = int.Parse(textBoxDisciplina.Text);
                p.Naziv = textBoxNaziv.Text;
                p.MSA = textBoxMSA.Text;


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
