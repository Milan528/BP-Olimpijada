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
    public partial class FormaZemlja : Form
    {
        int idTakmicenja;
        public FormaZemlja(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        private void FormaZemlja_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<ZemljaPregled> odInfos = ZemljaManager.PrikaziZemlje(idTakmicenja);
            foreach (ZemljaPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.JednistvenaSkracenica,op.Ime,op.Kontinent });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            string id= listView1.SelectedItems[0].SubItems[0].Text;
            string ime= listView1.SelectedItems[0].SubItems[1].Text;

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems != null)
                {
                    string id = listView1.SelectedItems[0].SubItems[0].Text;
                    ISession s = DataLayer.GetSession();
                    Zemlja z = s.Load<Zemlja>(id);
                    s.Delete(z);
                    s.Flush();
                    s.Close();
                }
                else
                    MessageBox.Show("Selektujte zemlju ");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }*/
    }
}
