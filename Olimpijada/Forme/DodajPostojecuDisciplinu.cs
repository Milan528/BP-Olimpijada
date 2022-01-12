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
    public partial class DodajPostojecuDisciplinu : Form
    {
        int idTakmicenja;
        public DodajPostojecuDisciplinu(int idTakmicenja)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
        }

        private void DodajPostojecuDisciplinu_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<DisciplinePregled> odInfos = DisciplineManager.PrikaziSveDiscipline();
            foreach (DisciplinePregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Id.ToString(), op.Ime, op.Tip, op.SvetskiRekord.ToString(), op.OlimpijskiRekord.ToString(), op.ProslogodisnjiRezultat.ToString(), op.SvetskiSampion, op.OlimpijskiSampion });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                ISession s = DataLayer.GetSession();
                Disciplina disciplina = s.Load<Disciplina>(id);
                Takmicenje t = s.Load<Takmicenje>(idTakmicenja);
                OdrzavaSe sa = new OdrzavaSe();
                sa.OdrzavaSeId.IdDiscipline = disciplina;
                sa.OdrzavaSeId.IdTakmicenje = t;

                s.Save(sa);
                s.Flush();
                
                s.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Odaberite disciplinu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int Id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                ISession s = DataLayer.GetSession();


                Olimpijada.Entiteti.Disciplina p = s.Load<Olimpijada.Entiteti.Disciplina>(Id);
                s.Delete(p);


                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                //MessageBox.Show(ec.Message);
                MessageBox.Show("Odaberite disciplinu");
            }
            PopulateInfos();
        }
    }
}
