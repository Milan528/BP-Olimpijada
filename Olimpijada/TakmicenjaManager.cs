using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olimpijada.Entiteti;
using NHibernate.Linq;
using System.Windows.Forms;

namespace Olimpijada
{
    public class SportManager
    {
        public static List<SportPregled> PrikaziSportove(int idDiscipline)
        {
            List<SportPregled> listaSportova = new List<SportPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ImaDisciplinu> imaDiscipline = from o in s.Query<ImaDisciplinu>()
                                                       where o.Id.SifraDiscipline.Id == idDiscipline
                                                       select o;
                IEnumerable<Sport> sportovi;

                foreach(ImaDisciplinu i in imaDiscipline)
                {
                    sportovi = from o in s.Query<Sport>()
                               where o.ID == i.Id.IdSporta.ID
                               select o;
                    foreach(Sport sp in sportovi)
                    {
                        listaSportova.Add(new SportPregled(sp.BrojDiscipline,sp.TipSporta,sp.Naziv,sp.MSA,sp.ID));
                    }
                }
                s.Close();
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listaSportova;
        }
        public static List<SportPregled> PrikaziSportove(string tip)
        {
            List<SportPregled> listaSportova = new List<SportPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Sport> imaDiscipline = from o in s.Query<Sport>()
                                                           where o.TipSporta == tip
                                                           select o;
              

                foreach (Sport sp in imaDiscipline)
                {
                    
                   
                        listaSportova.Add(new SportPregled(sp.BrojDiscipline, sp.TipSporta, sp.Naziv, sp.MSA, sp.ID));
                    
                }
                s.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listaSportova;
        }

        public static List<SportPregled> PrikaziSportove()
        {
            List<SportPregled> listaSportova = new List<SportPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Sport> imaDiscipline = from o in s.Query<Sport>()
                                                   select o;


                foreach (Sport sp in imaDiscipline)
                {


                    listaSportova.Add(new SportPregled(sp.BrojDiscipline, sp.TipSporta, sp.Naziv, sp.MSA, sp.ID));

                }
                s.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listaSportova;
        }
        public static List<SportPregled> PrikaziSport(int id)
        {
            List<SportPregled> listaSportova = new List<SportPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Sport> imaDiscipline = from o in s.Query<Sport>()
                                                   where o.ID==id
                                                   select o;


                foreach (Sport sp in imaDiscipline)
                {


                    listaSportova.Add(new SportPregled(sp.BrojDiscipline, sp.TipSporta, sp.Naziv, sp.MSA, sp.ID));

                }
                s.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return listaSportova;
        }
    }
    public class TakmicenjaManager
    {

        public static List<TakmicenjaPregled> PrikaziTakmicenje(int id)
        {
            List<TakmicenjaPregled> listaTakmicenja = new List<TakmicenjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Takmicenje> takmicenja = from o in s.Query<Takmicenje>()
                                                     where o.ID==id
                                                     select o;



                foreach (Takmicenje o in takmicenja)
                {
                    listaTakmicenja.Add(new TakmicenjaPregled(o.ID, o.NazivStadiona, o.DatumOdrzavanja, o.VremeOdrzavanja));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaTakmicenja;
        }

        public static List<TakmicenjaPregled> PrikaziTakmicenja()
        {
            List<TakmicenjaPregled> listaTakmicenja = new List<TakmicenjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Takmicenje> takmicenja = from o in s.Query<Takmicenje>()
                                                   // where o.ID == 1
                                                    select o;

               

                foreach (Takmicenje o in takmicenja)
                {
                    listaTakmicenja.Add(new TakmicenjaPregled(o.ID,o.NazivStadiona, o.DatumOdrzavanja, o.VremeOdrzavanja));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaTakmicenja;
        }
    }

    public class SportistaManager
    {
        public static List<SportistaPregled> PrikaziSportiste(int idTakmicenja)
        {
            List<SportistaPregled> listaSportista = new List<SportistaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

              

                IEnumerable<Ucestvuje> ucestvuju =  from o in s.Query<Ucestvuje>()
                                                    where o.IdTakmicenja.ID == idTakmicenja
                                                    select o;
                IEnumerable<Sportista> sportisti;

                foreach (Ucestvuje u in ucestvuju)
                {
                    sportisti = from o in s.Query<Sportista>()
                                where o.IdSportista == u.IdSportiste.IdSportista
                                select o;

                    foreach (Sportista sportista in sportisti)
                        listaSportista.Add(new SportistaPregled(sportista.Zemlja, sportista.LicnoIme, sportista.Prezime, sportista.Inicijali, sportista.IdSportista, sportista.PredstavljaZemlju.JedinstvenaSkracenica,u.Medalja,u.Mesto));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSportista;
        }

        public static List<SportistaPregledWeb> PrikaziSportiste()
        {
            List<SportistaPregledWeb> listaSportista = new List<SportistaPregledWeb>();
            try
            {
                ISession s = DataLayer.GetSession();



                

                IEnumerable < Sportista > sportisti = from o in s.Query<Sportista>()
                                                      select o; 



                foreach (Sportista sportista in sportisti)
                        listaSportista.Add(new SportistaPregledWeb(sportista.Zemlja, sportista.LicnoIme, sportista.Prezime, sportista.Inicijali, sportista.IdSportista, sportista.PredstavljaZemlju.JedinstvenaSkracenica));
                

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSportista;
        }

        public static List<SportistaPregledWeb> PrikaziSportistu(int id)
        {
            List<SportistaPregledWeb> listaSportista = new List<SportistaPregledWeb>();
            try
            {
                ISession s = DataLayer.GetSession();





                IEnumerable<Sportista> sportisti = from o in s.Query<Sportista>()
                                                   where o.IdSportista==id
                                                   select o;



                foreach (Sportista sportista in sportisti)
                    listaSportista.Add(new SportistaPregledWeb(sportista.Zemlja, sportista.LicnoIme, sportista.Prezime, sportista.Inicijali, sportista.IdSportista, sportista.PredstavljaZemlju.JedinstvenaSkracenica));


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSportista;
        }
        public static List<SportistaPregled> PrikaziTakmicare(int idDiscipline)
        {
            List<SportistaPregled> listaSportista = new List<SportistaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();



                IEnumerable<TakmiciSe> takmicari = from o in s.Query<TakmiciSe>()
                                                   where o.SifraDiscipline.Id==idDiscipline
                                                   select o;
                IEnumerable<Sportista> sportisti;

                foreach (TakmiciSe u in takmicari)
                {
                    sportisti = from o in s.Query<Sportista>()
                                where o.IdSportista == u.IdSportiste.IdSportista
                                select o;

                    foreach (Sportista sportista in sportisti)
                        listaSportista.Add(new SportistaPregled(sportista.Zemlja, sportista.LicnoIme, sportista.Prezime, sportista.Inicijali, sportista.IdSportista, sportista.PredstavljaZemlju.JedinstvenaSkracenica,u.LicniRekord));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSportista;
        }
        public static List<SportistaPregled> PrikaziSveSportiste()
        {
            List<SportistaPregled> listaSportista = new List<SportistaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                //bool flag;
               

                /*IEnumerable<Ucestvuje> ucestvuju = from o in s.Query<Ucestvuje>()
                                                   select o;*/
                IEnumerable<Sportista> sportisti = from o in s.Query <Sportista>()
                                                   select o;

                
               
                foreach (Sportista sportista in sportisti)  
                 {


                     // = true;

                    /* foreach (Ucestvuje u in ucestvuju)
                         {
                         */
                        /*if (flag)
                         {*/
                listaSportista.Add(new SportistaPregled(sportista.Zemlja, sportista.LicnoIme,
                    sportista.Prezime, sportista.Inicijali, sportista.IdSportista,
                    sportista.PredstavljaZemlju.JedinstvenaSkracenica/*, u.Medalja, u.Mesto*/));

               /* flag = false;
                if(!(flag))*/
                //break;
                //}
                //}
        }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSportista;
        }
    }

    public class SudijaManager
    {
        public static List<SudijePregled> PrikaziSudiju(int id)
        {


            List<SudijePregled> listaSudija = new List<SudijePregled>();
            try
            {
                ISession s = DataLayer.GetSession();



                IEnumerable<Sudija> sude = from o in s.Query<Sudija>()
                                           where o.IdSudije==id
                                           select o;
               

                foreach (Sudija sud in sude)
                {
                    
                        listaSudija.Add(new SudijePregled(sud.Zemlja, sud.LicnoIme, sud.Prezime, sud.IdSudije, sud.Specijalnost));
                }

                s.Close();

            }

            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSudija;
        }
        public static List<SudijePregled> PrikaziSudije(int idTakmicenja)
        {
           
            
            List<SudijePregled> listaSudija = new List<SudijePregled>();
            try
            {
                ISession s = DataLayer.GetSession();



                IEnumerable<SudiNa> sude = from o in s.Query<SudiNa>()
                                                 where o.Id.IdTakmicenja.ID == idTakmicenja
                                           //  where o.IdTakmicenja.ID==idTakmicenja
                                             select o;
                IEnumerable<Sudija> sudije;

                foreach (SudiNa u in sude)
                {
                    sudije = from o in s.Query<Sudija>()
                             where o.IdSudije == u.Id.IdSudije.IdSudije
                             select o;

                    foreach (Sudija sud in sudije)
                        listaSudija.Add(new SudijePregled(sud.Zemlja,sud.LicnoIme,sud.Prezime,sud.IdSudije,sud.Specijalnost));
                }

                s.Close();

            }
 
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaSudija;
        }
        public static List<SudijePregled> PrikaziSveSudije()
        {


            List<SudijePregled> listaSudija = new List<SudijePregled>();
            try
            {
                ISession s = DataLayer.GetSession();



                IEnumerable<Sudija> sude = from o in s.Query<Sudija>()
                                          // where o.Id.IdTakmicenja.ID == idTakmicenja
                                           //  where o.IdTakmicenja.ID==idTakmicenja
                                           select o;

                foreach (Sudija u in sude)
                {
                   

                   
                        listaSudija.Add(new SudijePregled(u.Zemlja, u.LicnoIme, u.Prezime, u.IdSudije, u.Specijalnost));
                }

                s.Close();
            }

            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }
            
            return listaSudija;
        }
    }


    public class DisciplineManager
    {
        public static List<DisciplinePregled> PrikaziDiscipline(int idTakmicenja)
        {
            List<DisciplinePregled> listaDisciplina = new List<DisciplinePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

               
                IEnumerable<OdrzavaSe> discipline = from o in s.Query<OdrzavaSe>()
                                                    where o.OdrzavaSeId.IdTakmicenje.ID == idTakmicenja
                                                    select o;
                IEnumerable<Disciplina> disc;

                foreach(OdrzavaSe os in discipline)
                {
                    disc = from ose in s.Query<Disciplina>()
                           where ose.Id == os.OdrzavaSeId.IdDiscipline.Id
                           select ose;

                    foreach (Disciplina di in disc)
                        listaDisciplina.Add(new DisciplinePregled(di.Id,di.Ime,di.TipDiscipline,di.SvetskiRekord??0,di.OlimpijskiRekord??0,di.ProslogodisnjiRezultat??0,di.SvetskiPrvak,di.OlimpijskiPrvak));
                }
                s.Close();

            }
            
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaDisciplina;
        }


        public static List<DisciplinePregled> PrikaziSveDiscipline()
        {
            List<DisciplinePregled> listaDisciplina = new List<DisciplinePregled>();
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<Disciplina> discipline = from o in s.Query<Disciplina>()
                                                   // where o.OdrzavaSeId.IdTakmicenje.ID == idTakmicenja
                                                    select o;
               

                    foreach (Disciplina di in discipline)
                        listaDisciplina.Add(new DisciplinePregled(di.Id, di.Ime, di.TipDiscipline, di.SvetskiRekord ?? 0, di.OlimpijskiRekord ?? 0, di.ProslogodisnjiRezultat ?? 0, di.SvetskiPrvak, di.OlimpijskiPrvak));
               
                s.Close();

            }

            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaDisciplina;
        }
        public static List<DisciplinePregled> PrikaziSveDiscipline(int id)
        {
            List<DisciplinePregled> listaDisciplina = new List<DisciplinePregled>();
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<Disciplina> discipline = from o in s.Query<Disciplina>()
                                                      where o.Id == id
                                                      select o;


                foreach (Disciplina di in discipline)
                    listaDisciplina.Add(new DisciplinePregled(di.Id, di.Ime, di.TipDiscipline, di.SvetskiRekord ?? 0, di.OlimpijskiRekord ?? 0, di.ProslogodisnjiRezultat ?? 0, di.SvetskiPrvak, di.OlimpijskiPrvak));

                s.Close();

            }

            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaDisciplina;
        }
    }
    public class TakmiciSeManager
    {
        public static List<TakmiciSePregled> PrikaziTakmiciSe(int idDiscipline)
        {
            List<TakmiciSePregled> listaDisciplina = new List<TakmiciSePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TakmiciSe> discipline = from o in s.Query<TakmiciSe>()
                                                           where o.SifraDiscipline.Id == idDiscipline
                                                           select o;

                foreach (TakmiciSe d in discipline)
                {
                    //double rekord = d.SvetskiRekord ?? 0;
                    listaDisciplina.Add(new TakmiciSePregled(d.IdTakmiciSe,d.SifraDiscipline.Id,d.IdSportiste.IdSportista,d.LicniRekord));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaDisciplina;
        }
        public static List<TakmiciSePregled> VratiTakmicara(int idTakmicara,int idDiscipline)
        {
            List<TakmiciSePregled> listaDisciplina = new List<TakmiciSePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TakmiciSe> discipline = from o in s.Query<TakmiciSe>()
                                                    where (o.IdSportiste.IdSportista==idTakmicara &&o.SifraDiscipline.Id==idDiscipline)
                                                    select o;

                foreach (TakmiciSe d in discipline)
                {
                    //double rekord = d.SvetskiRekord ?? 0;
                    listaDisciplina.Add(new TakmiciSePregled(d.IdTakmiciSe, d.SifraDiscipline.Id, d.IdSportiste.IdSportista, d.LicniRekord));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaDisciplina;
        }
    }
    public class RezultatiManager
    {
        public static List<RezultatiPregled> PrikaziRezultate(int idDiscipline)
        {
            List<RezultatiPregled> listaDisciplina = new List<RezultatiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<OstvarenRezultat> discipline = from o in s.Query<OstvarenRezultat>()
                                                          where o.SifraDiscipline.Id == idDiscipline
                                                          select o;

                foreach (OstvarenRezultat d in discipline)
                {
                    //double rekord = d.SvetskiRekord ?? 0;
                    listaDisciplina.Add(new RezultatiPregled(d.IdOstvarenRezultat,d.SifraDiscipline.Id,d.SkracenicaZemlje.Ime,d.DatumPostizanja.ToString(),d.RezultatZemlje??0));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return listaDisciplina;
        }
    }

    public class UcestvujeManager
    {
        public static List<UcestvujePregled> VratiUcestovanja(int idSportiste,int idTakmicenja)
        {
            List<UcestvujePregled> listaUcestvuje = new List<UcestvujePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ucestvuje> u = from o in s.Query<Ucestvuje>()
                                                    where (o.IdTakmicenja.ID==idTakmicenja && o.IdSportiste.IdSportista==idSportiste)
                                                    select o;

                foreach (Ucestvuje d in u)
                {
                    //double rekord = d.SvetskiRekord ?? 0;
                    listaUcestvuje.Add(new UcestvujePregled(d.IdUcestvuje, d.IdSportiste.IdSportista, d.IdTakmicenja.ID, d.Mesto,d.Medalja));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }

            return listaUcestvuje;
        }
    }

    public class SudiNaManager
    {
        public static List<SudiNaPregled> VratiSudiNa(int idSudije,int idTakmicenja)
        {

            List<SudiNaPregled> listaSudiNa = new List<SudiNaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SudiNa> u = from o in s.Query<SudiNa>()
                                           where (o.Id.IdSudije.IdSudije==idSudije && o.Id.IdTakmicenja.ID==idTakmicenja)
                                           select o;

                foreach (SudiNa d in u)
                {
                    //double rekord = d.SvetskiRekord ?? 0;
                    listaSudiNa.Add(new SudiNaPregled(d.Id.IdSudije.IdSudije,d.Id.IdTakmicenja.ID));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
                Console.WriteLine(ec.Message);
            }


            return listaSudiNa;
        }
    }

    public class ZemljaManager
    {
        public static List<ZemljaPregled> PrikaziZemlju(string jskr)
        {
            List<ZemljaPregled> zemlje = new List<ZemljaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zemlja> zemlja = from o in s.Query<Zemlja>()
                                                   where o.JedinstvenaSkracenica==jskr
                                                   select o;

                

                foreach(Zemlja u in zemlja)
                    zemlje.Add(new ZemljaPregled(u.JedinstvenaSkracenica, u.Ime, u.Kontinent));
                

                s.Close();


            }
            catch (Exception)
            {

            }
            return zemlje;
        }

        public static List<ZemljaPregled> PrikaziZemlje(int idTakmicenja)
        {
            List<ZemljaPregled> zemlje = new List<ZemljaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ucestvuje> sportisti = from o in s.Query<Ucestvuje>()
                                                          where o.IdTakmicenja.ID == idTakmicenja
                                                          select o;
                
                foreach(Ucestvuje u in sportisti)
                {
                   

                    zemlje.Add(new ZemljaPregled(u.IdSportiste.PredstavljaZemlju.JedinstvenaSkracenica, u.IdSportiste.PredstavljaZemlju.Ime, u.IdSportiste.PredstavljaZemlju.Kontinent ));
                }

                s.Close();                                        


            }
            catch(Exception)
            {

            }
            return zemlje;
        }
        public static List<ZemljaPregled> UcitajZemlje()
        {
            List<ZemljaPregled> zemlje = new List<ZemljaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zemlja> sportisti = from o in s.Query<Zemlja>()
                                                 select o;

                foreach (Zemlja u in sportisti)
                {
                    

                    zemlje.Add(new ZemljaPregled(u.JedinstvenaSkracenica,u.Ime,u.Kontinent));
                }

                s.Close();


            }
            catch (Exception)
            {

            }
            return zemlje;
        }

    }

}
