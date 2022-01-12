using NHibernate;
using Olimpijada.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada
{
    public class DataProvider
    {
        public class SudijaProvider
        {
            public static int AddSudija(Sudija sudija)
            {
                try
                {
                   
                    ISession s = DataLayer.GetSession();
                    s.Save(sudija);
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int DeleteSudija(int id)
            {
                try
                {

                    ISession s = DataLayer.GetSession();



                    Sudija sudija  = s.Load<Sudija>(id);
                    s.Delete(sudija);

                   
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int PutSudija(int id,Sudija sudija)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Sudija p = s.Load<Olimpijada.Entiteti.Sudija>(id);



                    if(sudija.Zemlja!=null)
                     p.Zemlja = sudija.Zemlja;
                    if (sudija.LicnoIme != null)
                        p.LicnoIme = sudija.LicnoIme;
                    if (sudija.Prezime != null)
                        p.Prezime = sudija.Prezime;
                    if (sudija.Specijalnost != null)
                        p.Specijalnost = sudija.Specijalnost;



                    s.Update(p);
                    s.Flush();
                    s.Close();
                    return 0;

                }
                catch (Exception ec)
                {
                    return -1;
                }

            }
        }

        public class SportistaProvider
        {

            public static int AddSportista(SportistaPregledWeb sportista)
            {
                try
                {


                    ISession s = DataLayer.GetSession();
                    Sportista p = new Sportista();

                    if (sportista.Zemlja != null)
                        p.Zemlja = sportista.Zemlja;
                    if (sportista.LicnoIme != null)
                        p.LicnoIme = sportista.LicnoIme;
                    if (sportista.Prezime != null)
                        p.Prezime = sportista.Prezime;
                    if (sportista.Inicijali != null)
                        p.Inicijali = sportista.Inicijali;

                    Zemlja z = s.Load<Zemlja>(sportista.PredstavljaZemlju);

                    if (z != null)
                        p.PredstavljaZemlju = z;
                    else
                        throw new Exception();

                    s.Save(p);
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int DeleteSportista(int id)
            {
                try
                {

                    ISession s = DataLayer.GetSession();


                    Sportista sportista = s.Load<Sportista>(id);
                    s.Delete(sportista);


                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int PutSportista(int id, SportistaPregledWeb sportista)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Sportista p = s.Load<Olimpijada.Entiteti.Sportista>(id);


                    if(sportista.Zemlja!=null)
                     p.Zemlja = sportista.Zemlja;
                    if(sportista.LicnoIme!=null)
                     p.LicnoIme = sportista.LicnoIme;
                    if (sportista.Prezime != null)
                        p.Prezime = sportista.Prezime;
                    if (sportista.Inicijali != null)
                        p.Inicijali = sportista.Inicijali;

                    Zemlja z = s.Load<Zemlja>(sportista.PredstavljaZemlju);

                    if (z.Ime != null)
                        p.PredstavljaZemlju = z;
                    else
                        throw new Exception();

                  


                    s.Update(p);
                    s.Flush();
                    s.Close();
                    return 0;

                }
                catch (Exception ec)
                {
                    return -1;
                }

            }
        }

        public class ZemljaProvider
        {
            public static int AddZemlja(ZemljaPregled zemlja)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Zemlja p = new Zemlja();

                    if (zemlja.Ime != null)
                        p.Ime = zemlja.Ime;
                    if (zemlja.Kontinent != null)
                        p.Kontinent = zemlja.Kontinent;
                    if (zemlja.JednistvenaSkracenica != null)
                        p.JedinstvenaSkracenica = zemlja.JednistvenaSkracenica;

                    s.Save(p);
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }

            public static int DeleteZemlja(string jskr)
            {
                try
                {

                    ISession s = DataLayer.GetSession();
                    Zemlja zemlja = s.Load<Zemlja>(jskr);
                    s.Delete(zemlja);

                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int PutZemlja(string jskr, ZemljaPregled zemlja)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Zemlja p = s.Load<Olimpijada.Entiteti.Zemlja>(jskr);


                    if (zemlja.Ime != null)
                        p.Ime = zemlja.Ime;
                    if (zemlja.Kontinent != null)
                        p.Kontinent = zemlja.Kontinent;
                   
                    s.Update(p);
                    s.Flush();
                    s.Close();
                    return 0;

                }
                catch (Exception ec)
                {
                    return -1;
                }

            }
        }

        public class SportProvider
        {
            public static int AddSport(SportPregled sport)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Sport p = new Sport();

                    if (sport.MSA != null)
                        p.MSA = sport.MSA;
                    if (sport.Naziv != null)
                        p.Naziv = sport.Naziv;
                    if (sport.TipSporta != null)
                        p.TipSporta = sport.TipSporta;
                
                        p.BrojDiscipline = sport.BrojDiscipline;

                    s.Save(p);
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }

            public static int DeleteSport(int id)
            {
                try
                {

                    ISession s = DataLayer.GetSession();
                    Sport sport = s.Load<Sport>(id);
                    s.Delete(sport);

                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int PutSport(int id, SportPregled sport)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Sport p = s.Load<Olimpijada.Entiteti.Sport>(id);


                    if (sport.MSA != null)
                        p.MSA = sport.MSA;
                    if (sport.Naziv != null)
                        p.Naziv = sport.Naziv;
                    if (sport.TipSporta != null)
                        p.TipSporta = sport.TipSporta;

                    p.BrojDiscipline = sport.BrojDiscipline;

                    s.Update(p);
                    s.Flush();
                    s.Close();
                    return 0;

                }
                catch (Exception ec)
                {
                    return -1;
                }

            }
        }

        public class DisciplinaProvider
        {
            public static int AddDisciplina(DisciplinePregled disciplina)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Disciplina p = new Disciplina();

                    if (disciplina.Ime != "")
                        p.Ime = disciplina.Ime;
                    if (disciplina.Tip != "")
                    {
                        p.TipDiscipline = disciplina.Tip;
                        if (disciplina.Tip == "POJEDINACNA")
                        {
                            if (disciplina.SvetskiRekord != null)
                                p.SvetskiRekord = disciplina.SvetskiRekord;
                            if (disciplina.ProslogodisnjiRezultat != null)
                                p.ProslogodisnjiRezultat = disciplina.ProslogodisnjiRezultat;
                            if (disciplina.OlimpijskiRekord != null)
                                p.OlimpijskiRekord = disciplina.OlimpijskiRekord;
                        }
                        else if (disciplina.Tip == "EKIPNA")
                        {
                            if (disciplina.SvetskiSampion != null)
                                p.SvetskiPrvak = disciplina.SvetskiSampion;
                            if (disciplina.OlimpijskiSampion != null)
                                p.OlimpijskiPrvak = disciplina.OlimpijskiSampion;

                        }
                        else if (disciplina.Tip == "KOMBINOVANA")
                        {
                            if (disciplina.SvetskiRekord != null)
                                p.SvetskiRekord = disciplina.SvetskiRekord;
                            if (disciplina.ProslogodisnjiRezultat != null)
                                p.ProslogodisnjiRezultat = disciplina.ProslogodisnjiRezultat;
                            if (disciplina.OlimpijskiRekord != null)
                                p.OlimpijskiRekord = disciplina.OlimpijskiRekord;
                            if (disciplina.SvetskiSampion != null)
                                p.SvetskiPrvak = disciplina.SvetskiSampion;
                            if (disciplina.OlimpijskiSampion != null)
                                p.OlimpijskiPrvak = disciplina.OlimpijskiSampion;
                        }
                        else
                            throw new Exception();
                    }







                       

                   

                    s.Save(p);
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }

            public static int DeleteDisciplina(int id)
            {
                try
                {

                    ISession s = DataLayer.GetSession();
                    Disciplina d = s.Load<Disciplina>(id);
                    s.Delete(d);

                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int PutDisciplina(int id, DisciplinePregled disciplina)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Disciplina p = s.Load<Olimpijada.Entiteti.Disciplina>(id);

                    if (disciplina.Ime != "")
                        p.Ime = disciplina.Ime;
                    if (disciplina.Tip != "")
                    {
                        if (disciplina.Tip == "POJEDINACNA")
                        {
                            if (disciplina.SvetskiRekord != null)
                                p.SvetskiRekord = disciplina.SvetskiRekord;
                            if (disciplina.ProslogodisnjiRezultat != null)
                                p.ProslogodisnjiRezultat = disciplina.ProslogodisnjiRezultat;
                            if (disciplina.OlimpijskiRekord != null)
                                p.OlimpijskiRekord = disciplina.OlimpijskiRekord;
                        }
                        else if (disciplina.Tip == "EKIPNA")
                        {
                            if (p.SvetskiPrvak != null)
                                p.SvetskiPrvak = disciplina.SvetskiSampion;
                            if (p.OlimpijskiPrvak != null)
                                p.OlimpijskiPrvak = disciplina.OlimpijskiSampion;

                        }
                        else if (disciplina.Tip == "KOMBINOVANA")
                        {
                            if (disciplina.SvetskiRekord != null)
                                p.SvetskiRekord = disciplina.SvetskiRekord;
                            if (disciplina.ProslogodisnjiRezultat != null)
                                p.ProslogodisnjiRezultat = disciplina.ProslogodisnjiRezultat;
                            if (disciplina.OlimpijskiRekord != null)
                                p.OlimpijskiRekord = disciplina.OlimpijskiRekord;
                            if (p.SvetskiPrvak != null)
                                p.SvetskiPrvak = disciplina.SvetskiSampion;
                            if (p.OlimpijskiPrvak != null)
                                p.OlimpijskiPrvak = disciplina.OlimpijskiSampion;
                        }
                        else
                            throw new Exception();
                    }

                        s.Update(p);
                        s.Flush();
                        s.Close();
                        return 0;
                    

                }
                catch (Exception ec)
                {
                    return -1;
                }

            }

          
        }


        public class TakmicenjeProvider
        {
            public static int AddTakmicenje(TakmicenjaPregled takmicenje)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    Takmicenje p = new Takmicenje();

                    if (takmicenje.Naziv != "")
                        p.NazivStadiona = takmicenje.Naziv;
                    if (takmicenje.VremeOdrzavanja != "")
                        p.VremeOdrzavanja = takmicenje.VremeOdrzavanja;
                    if (takmicenje.DatumOdrzavanja != null)
                        p.DatumOdrzavanja = takmicenje.DatumOdrzavanja;


                    s.Save(p);
                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }

            public static int DeleteTakmicenje(int id)
            {
                try
                {

                    ISession s = DataLayer.GetSession();
                    Takmicenje d = s.Load<Takmicenje>(id);
                    s.Delete(d);

                    s.Flush();
                    s.Close();
                    return 0;
                }
                catch (Exception x)
                {
                    return -1;
                }

            }


            public static int PutTakmicenje(int id, TakmicenjaPregled takmicenje)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Takmicenje p = s.Load<Olimpijada.Entiteti.Takmicenje>(id);

                    if (takmicenje.Naziv != "")
                        p.NazivStadiona = takmicenje.Naziv;
                    if (takmicenje.VremeOdrzavanja != "")
                        p.VremeOdrzavanja = takmicenje.VremeOdrzavanja;
                    if (takmicenje.DatumOdrzavanja != null)
                        p.DatumOdrzavanja = takmicenje.DatumOdrzavanja;

                    s.Update(p);
                    s.Flush();
                    s.Close();
                    return 0;


                }
                catch (Exception ec)
                {
                    return -1;
                }

            }
        }
    }
}
