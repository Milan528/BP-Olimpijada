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
    public partial class IzmeniDisciplinu : Form
    {
        int id;

        public IzmeniDisciplinu(int id, string ime, string tip, string svetskiRekord, string olimpijskiRekord, string proslogodisnjiRezultat, string svetskiSampion, string OlimpijskiSampion)
        {
            InitializeComponent();
            
            this.id = id;
            textBoxIme.Text = ime;
            comboBoxTip.SelectedIndex = comboBoxTip.FindStringExact(tip);
            textBoxSvetskiRezultat.Text = svetskiRekord;
            textBoxOlimpijskiRezultat.Text = olimpijskiRekord;
            textBoxProslogodisnjiRezultat.Text = proslogodisnjiRezultat;
            textBoxSvetskiSampion.Text = svetskiSampion;
            textBoxOlimpijskiSmpion.Text = OlimpijskiSampion;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Olimpijada.Entiteti.Disciplina p = s.Load<Olimpijada.Entiteti.Disciplina>(id);

               


                p.Ime = textBoxIme.Text;
                p.TipDiscipline = comboBoxTip.SelectedItem.ToString();
                p.SvetskiRekord = double.Parse(textBoxSvetskiRezultat.Text);
                p.OlimpijskiRekord = double.Parse(textBoxOlimpijskiRezultat.Text);
                p.ProslogodisnjiRezultat = double.Parse(textBoxProslogodisnjiRezultat.Text);
                p.SvetskiPrvak = textBoxSvetskiSampion.Text;
                p.OlimpijskiPrvak = textBoxOlimpijskiSmpion.Text;

           
                

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

        private void IzmeniDisciplinu_Load(object sender, EventArgs e)
        {

        }
    }
}
