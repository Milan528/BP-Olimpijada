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
    public partial class DodajDisciplinu : Form
    {
        int idTakmicenja;
        //int idDiscipline;
        public DodajDisciplinu(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;


        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Olimpijada.Entiteti.Disciplina p = new Olimpijada.Entiteti.Disciplina();


                p.Ime = textBoxIme.Text;
                p.TipDiscipline = comboBoxTip.SelectedItem.ToString();
                if (textBoxSvetskiRezultat.Text != "")
                    p.SvetskiRekord = double.Parse(textBoxSvetskiRezultat.Text);
                else
                    p.SvetskiRekord = null;
                if (textBoxOlimpijskiRezultat.Text != "")
                    p.OlimpijskiRekord = double.Parse(textBoxOlimpijskiRezultat.Text);
                else
                    p.OlimpijskiRekord = null;
                if (textBoxProslogodisnjiRezultat.Text != "")
                    p.ProslogodisnjiRezultat = double.Parse(textBoxProslogodisnjiRezultat.Text);
                else
                    p.ProslogodisnjiRezultat = null;
                p.SvetskiPrvak = textBoxSvetskiSampion.Text;
                p.OlimpijskiPrvak = textBoxOlimpijskiSmpion.Text;


                Console.WriteLine("Dodato");
                s.Save(p);


                OdrzavaSe o = new OdrzavaSe();
                o.OdrzavaSeId.IdDiscipline = p;
                Takmicenje t = s.Load<Takmicenje>(idTakmicenja);
                o.OdrzavaSeId.IdTakmicenje = t;

                s.Save(o);
                s.Flush();
                s.Close();
                this.Close();


            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message);
                MessageBox.Show("Niste uneli ispravne podatke");
            }
            
        }

        private void comboBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTip.SelectedItem.ToString() == "KOMBINOVANA")
            {
                groupBoxEkipne.Visible = true;
                groupBoxPojedinacne.Visible = true;
            }
            else if (comboBoxTip.SelectedItem.ToString() == "POJEDINACNA")
            {
                groupBoxEkipne.Visible = false;
                groupBoxPojedinacne.Visible = true;
            }
            else
            {
                groupBoxEkipne.Visible = true;
                groupBoxPojedinacne.Visible = false;
            }
        }

        private void textBoxOlimpijskiSmpion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSvetskiSampion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProslogodisnjiRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOlimpijskiRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSvetskiRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void DodajDisciplinu_Load(object sender, EventArgs e)
        {
            groupBoxEkipne.Visible = false;
            groupBoxPojedinacne.Visible = false;
        }
    }
}
