using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Olimpijada.Forme
{
    public partial class IzmeniRezultat : Form
    {
        int id;
        public IzmeniRezultat(int id,double rezultat,DateTime dateTime)
        {
            InitializeComponent();
            this.id = id;
            textBox1.Text = rezultat.ToString();
            dateTimePicker1.Value = dateTime;

        }

        private void IzmeniRezultat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Olimpijada.Entiteti.OstvarenRezultat p = s.Load<Olimpijada.Entiteti.OstvarenRezultat>(id);

                p.DatumPostizanja = dateTimePicker1.Value;
                p.RezultatZemlje = double.Parse(textBox1.Text);

                s.Save(p);
                s.Flush();
                s.Close();
                this.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show("Podaci nisu ispravno uneti");
            }
            
        }
    }
}
