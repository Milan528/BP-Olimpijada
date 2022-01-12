using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using Olimpijada.Entiteti;

namespace Olimpijada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Disciplina p = s.Load<Olimpijada.Entiteti.Disciplina>(2);

                

                MessageBox.Show(p.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Takmicenje p = s.Load<Olimpijada.Entiteti.Takmicenje>(2);



                MessageBox.Show("Naziv stadiona: "+p.NazivStadiona);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sport p = s.Load<Olimpijada.Entiteti.Sport>(2);



                MessageBox.Show(p.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Olimpijada.Entiteti.Sudija p = s.Load<Olimpijada.Entiteti.Sudija>(2);



                MessageBox.Show(p.LicnoIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(2);



                MessageBox.Show(p.LicnoIme + " " + p.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Zemlja p = s.Load<Olimpijada.Entiteti.Zemlja>("SER");



                MessageBox.Show(p.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Disciplina p = new Olimpijada.Entiteti.Disciplina();

                p.Ime = "Zenska";
                p.TipDiscipline = "EKIPNA";
                p.SvetskiRekord = 12;
                p.OlimpijskiRekord = 12;
                p.ProslogodisnjiRezultat = 15;
                p.SvetskiPrvak = "Srbija";
                p.OlimpijskiPrvak = "Srbija";

                Console.WriteLine(p.Ime + " " + p.TipDiscipline);
                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Zemlja p = new Olimpijada.Entiteti.Zemlja();

                p.JedinstvenaSkracenica = "INN";
                p.Kontinent = "Azija";
                p.Ime = "Indija";
                

                Console.WriteLine(p.Ime + " - " + p.Kontinent);
                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");

               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sport p = new Olimpijada.Entiteti.Sport();


                p.TipSporta = "Kombinovani";
                p.BrojDiscipline = 1;
                p.Naziv = "Hokej";
                p.MSA = "ISF";
              


                Console.WriteLine(p.MSA);
                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");

               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Takmicenje p = new Olimpijada.Entiteti.Takmicenje();


                p.NazivStadiona = "Marakana";
                p.VremeOdrzavanja = "12:15";
                p.DatumOdrzavanja= DateTime.Now;


                Console.WriteLine("Dodato");
                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

            
            Olimpijada.Entiteti.Sudija p = new Olimpijada.Entiteti.Sudija();


            p.Zemlja = "Srbija";
            p.LicnoIme= "Marko";
            p.Prezime= "Markovic";
            p.Specijalnost = "Linijski"; 

            Console.WriteLine("Dodato");
            s.Save(p);
            s.Flush();
            s.Close();



            MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sportista p = new Olimpijada.Entiteti.Sportista();
                Zemlja z = s.Load<Zemlja>("TUN");

                p.Zemlja = "Srbija";
                p.LicnoIme= "Marko";
                p.Prezime= "Markovic";
                p.Inicijali= "MM";
                p.PredstavljaZemlju = z;

                Console.WriteLine("Dodato");
                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Disciplina p = s.Load<Olimpijada.Entiteti.Disciplina>(2);


                foreach(Sport sport in  p.Sportovi)
                    MessageBox.Show(sport.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Takmicenje p = s.Load<Olimpijada.Entiteti.Takmicenje>(2);


                foreach (Sportista sportista in p.Sportisti)
                    MessageBox.Show(sportista.LicnoIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sport p = s.Load<Olimpijada.Entiteti.Sport>(2);


                foreach (Disciplina d in p.Disciplinas)
                    MessageBox.Show(d.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sudija p = s.Load<Olimpijada.Entiteti.Sudija>(2);


                foreach (Takmicenje t in p.Takmicenja)
                    MessageBox.Show(t.NazivStadiona);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(2);


                foreach (Takmicenje t in p.Takmicenja)
                    MessageBox.Show(t.NazivStadiona);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Zemlja p = s.Load<Olimpijada.Entiteti.Zemlja>("SER");


                foreach (Disciplina o in p.Discipline)
                    MessageBox.Show(o.TipDiscipline);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Ucestvuje p = new Olimpijada.Entiteti.Ucestvuje();
                Sportista z = s.Load<Sportista>(1);
                Takmicenje t = s.Load<Takmicenje>(4);

                p.IdSportiste = z;
                p.IdTakmicenja = t;
                p.Mesto = 10;
                p.Medalja = null;
                

                
                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.TakmiciSe p = new Olimpijada.Entiteti.TakmiciSe();
                Sportista z = s.Load<Sportista>(1);
                Disciplina t = s.Load<Disciplina>(4);

                p.IdSportiste = z;
                p.SifraDiscipline = t;
                p.LicniRekord = 30;
                



                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.OstvarenRezultat p = new Olimpijada.Entiteti.OstvarenRezultat();
                Zemlja z = s.Load<Zemlja>("SER");
                Disciplina t = s.Load<Disciplina>(4);

                p.SkracenicaZemlje = z;
                p.SifraDiscipline = t;
                p.RezultatZemlje = 999;
                p.DatumPostizanja = DateTime.Now;




                s.Save(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Dodato");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Disciplina p = s.Load<Olimpijada.Entiteti.Disciplina>(1);


                foreach (TakmiciSe t in p.TakmiceSe)
                    MessageBox.Show(t.IdSportiste.LicnoIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Takmicenje p = s.Load<Olimpijada.Entiteti.Takmicenje>(2);


                foreach (Ucestvuje u in p.Ucesnici)
                    MessageBox.Show(u.Mesto.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sport p = s.Load<Olimpijada.Entiteti.Sport>(2);


                foreach (ImaDisciplinu i in p.ImaDiscipline)
                    MessageBox.Show(i.Id.SifraDiscipline.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sudija p = s.Load<Olimpijada.Entiteti.Sudija>(2);


                foreach (SudiNa t in p.SudiNa)
                    MessageBox.Show(t.Id.IdTakmicenja.NazivStadiona);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(2);


                foreach (TakmiciSe t in p.TakmiciSeU)
                    MessageBox.Show(t.LicniRekord.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Olimpijada.Entiteti.Zemlja p = s.Load<Olimpijada.Entiteti.Zemlja>("SER");


                foreach (OstvarenRezultat o in p.OstvareniRezultati)
                    MessageBox.Show(o.RezultatZemlje.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

              
                Olimpijada.Entiteti.Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(54);
                s.Delete(p); 
                
                MessageBox.Show("Izbrisano");
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

              
                Olimpijada.Entiteti.OstvarenRezultat p = s.Load<OstvarenRezultat>(48);

                s.Delete(p);
                s.Flush();
                s.Close();



                MessageBox.Show("Izbrisano: "+p.IdOstvarenRezultat);


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Button30_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o disciplini za zadatim brojem
                Olimpijada.Entiteti.OstvarenRezultat p = s.Load<OstvarenRezultat>(3);


                s.Close();
                ISession s1 = DataLayer.GetSession();

                p.RezultatZemlje = 50010;
                s1.Update(p);
                s1.Flush();
                s1.Close();
                MessageBox.Show("Azurirano");




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
