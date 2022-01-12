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

namespace Olimpijada.Forme
{
    public partial class DodajOstvarenRezultat : Form
    {
        int id;
        public DodajOstvarenRezultat(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DodajOstvarenRezultat_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<ZemljaPregled> odInfos = ZemljaManager.UcitajZemlje();
            foreach (ZemljaPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] {op.JednistvenaSkracenica,op.Ime,op.Kontinent});

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                label5.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();
                Zemlja z = s.Load<Zemlja>(label5.Text);
                Disciplina d = s.Load<Disciplina>(id);
                OstvarenRezultat rez = new OstvarenRezultat();
                rez.SifraDiscipline = d;
                rez.SkracenicaZemlje = z;
                rez.RezultatZemlje = double.Parse(textBox1.Text);
                rez.DatumPostizanja = dateTimePicker1.Value;
                s.Save(rez);
                s.Flush();
                s.Close();
                
            }
            catch(Exception x)
            {
                MessageBox.Show("Odaberite zemlju, njen rezultat i datum postizanja");
            }
            this.Close();
        }
    }
}
