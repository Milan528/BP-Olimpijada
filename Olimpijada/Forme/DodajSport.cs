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
    public partial class DodajSport : Form
    {
        int idDiscipline;
        string tipSporta;
        public DodajSport(int idDiscipline,string tipDiscipline)
        {
            InitializeComponent();
            this.idDiscipline = idDiscipline;
            if (tipDiscipline == "KOMBINOVANA")
                tipSporta = "Kombinovani";
            else if (tipDiscipline == "EKIPNA")
                tipSporta = "Ekipni";
            else
                tipSporta = "Pojedinacni";

            labelTipSporta.Text = tipSporta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Sport p = new Sport();
                ImaDisciplinu u = new ImaDisciplinu();


                p.BrojDiscipline = int.Parse(textBoxDisciplina.Text);
                p.Naziv = textBoxNaziv.Text;
                p.MSA = textBoxMSA.Text;
                p.TipSporta = tipSporta;

                s.Save(p);

                u.Id.IdSporta = p;
                Disciplina d = s.Load<Disciplina>(idDiscipline);
                u.Id.SifraDiscipline = d;

                s.Save(u);

                s.Flush();
               
                s.Close();

                this.Close();
            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message);
                MessageBox.Show("Niste uneli podatke dobro");
            }

        }
    }
}
