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
    public partial class IzmeniTakmiciSe : Form
    {
        int id;
        public IzmeniTakmiciSe(int id,double licniRekord)
        {
            InitializeComponent();
            this.id = id;
            textBoxLicniRekord.Text = licniRekord.ToString();
        }

        private void IzmeniTakmiciSe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Olimpijada.Entiteti.TakmiciSe p = s.Load<Olimpijada.Entiteti.TakmiciSe>(id);

                if (textBoxLicniRekord.Text != "")
                    p.LicniRekord = double.Parse(textBoxLicniRekord.Text);
                else
                    p.LicniRekord = 0;




                s.Update(p);
                s.Flush();
                s.Close();
                this.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("Unesite licni rekord");
            }
            
        }
    }
}
