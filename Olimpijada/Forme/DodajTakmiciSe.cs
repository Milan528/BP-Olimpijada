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
    public partial class DodajTakmiciSe : Form
    {
        int idTakmicenja;
        int idDiscipline;
        public DodajTakmiciSe(int idTakmicenja,int idDiscipline)
        {
            InitializeComponent();
            this.idTakmicenja = idTakmicenja;
            this.idDiscipline = idDiscipline;
        }

        private void DodajTakmiciSe_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }
        private void PopulateInfos()
        {
            listView1.Items.Clear();
            List<SportistaPregled> odInfos = SportistaManager.PrikaziSportiste(idTakmicenja);
            foreach (SportistaPregled op in odInfos)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    op.Zemlja,op.LicnoIme,op.Prezime,op.Inicijali,op.Id.ToString(),op.PredstavljaZemlju
                });

                listView1.Items.Add(item);
            }
            listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems!=null)
            label2.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (label2.Text != "")
                {
                    List<TakmiciSePregled> test = TakmiciSeManager.VratiTakmicara(int.Parse(label2.Text),idDiscipline);
                    if (test.Count == 0)
                    {
                        ISession s = DataLayer.GetSession();
                        TakmiciSe t = new TakmiciSe();
                        Disciplina d = s.Load<Disciplina>(idDiscipline);
                        Sportista sportista = s.Load<Sportista>(int.Parse(label2.Text));

                        t.SifraDiscipline = d;
                        t.IdSportiste = sportista;
                        if (textBoxLicniRekord.Text != "")
                            t.LicniRekord = double.Parse(textBoxLicniRekord.Text);
                        else
                            t.LicniRekord = 0;

                        s.Save(t);
                        s.Flush();
                        s.Close();
                    }
                    else
                        MessageBox.Show("Sportista se vec takmici u disciplini");
                }
                else
                    MessageBox.Show("Izaberite sportistu");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }

        }
    }
}
