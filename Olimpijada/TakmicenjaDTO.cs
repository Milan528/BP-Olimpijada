using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olimpijada.Entiteti;

namespace Olimpijada
{
    public class SportPregled
    {
        public int ID { get; set; }
        public string MSA { get; set; }
        public string TipSporta { get; set; }
        public string Naziv { get; set; }
        public int BrojDiscipline { get; set; }

        public SportPregled(int BrojDiscipline,string TipSporta,string Naziv,string MSA,int ID)
        {
            this.BrojDiscipline = BrojDiscipline;
            this.TipSporta = TipSporta;
            this.Naziv = Naziv;
            this.MSA = MSA;
            this.ID = ID;
        }
    }

    

    public class TakmicenjaPregled
    {
        public string Naziv { get; set; }
        public int Id { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string VremeOdrzavanja { get; set; }

        public TakmicenjaPregled(int Id,string Naziv, DateTime DatumOdrzavanja, string VremeOdrzavanja)
        {
            this.Id = Id;
            this.Naziv = Naziv;
            this.DatumOdrzavanja = DatumOdrzavanja;
            this.VremeOdrzavanja = VremeOdrzavanja;
        }
    }

    public class SportistaPregledWeb
    {
        public int Id { get; set; }
        public string LicnoIme { get; set; }
        public string Prezime { get; set; }
        public string Inicijali { get; set; }
        public string PredstavljaZemlju { get; set; }
        public string Zemlja { get; set; }


        public SportistaPregledWeb(string Zemlja, string LicnoIme, string Prezime, string Inicijali, int Id, string PredstavljaZemlju)
        {
            this.Id = Id;
            this.LicnoIme = LicnoIme;
            this.Prezime = Prezime;
            this.Inicijali = Inicijali;
            this.PredstavljaZemlju = PredstavljaZemlju;
            this.Zemlja = Zemlja;
            
        }


    }
    public class SportistaPregled
    {
        public int Id { get; set; }
        public string LicnoIme { get; set; }
        public string Prezime { get; set; }
        public string Inicijali { get; set; }
        public string PredstavljaZemlju { get; set; }
        public string Zemlja { get; set; }
        public string Medalja { get; set; }
        public int Mesto { get; set; }
        public double LicniRekord { get; set; }

        public SportistaPregled( string Zemlja ,string LicnoIme,  string Prezime, string Inicijali, int Id, string PredstavljaZemlju,string Medalja,int Mesto)
        {
            this.Id = Id;
            this.LicnoIme = LicnoIme;
            this.Prezime = Prezime;
            this.Inicijali = Inicijali;
            this.PredstavljaZemlju = PredstavljaZemlju;
            this.Zemlja = Zemlja;
            this.Medalja = Medalja;
            this.Mesto = Mesto;
        }
        public SportistaPregled(string Zemlja, string LicnoIme, string Prezime, string Inicijali, int Id, string PredstavljaZemlju)
        {
            this.Id = Id;
            this.LicnoIme = LicnoIme;
            this.Prezime = Prezime;
            this.Inicijali = Inicijali;
            this.PredstavljaZemlju = PredstavljaZemlju;
            this.Zemlja = Zemlja;
        }

        public SportistaPregled(string Zemlja, string LicnoIme, string Prezime, string Inicijali, int Id, string PredstavljaZemlju,double LicniRekord)
        {
            this.Id = Id;
            this.LicnoIme = LicnoIme;
            this.Prezime = Prezime;
            this.Inicijali = Inicijali;
            this.PredstavljaZemlju = PredstavljaZemlju;
            this.Zemlja = Zemlja;
            this.LicniRekord = LicniRekord;
        }



    }
    public class TakmiciSePregled
    {
        public int Id { get; set; }
        public int SifraDiscipline { get; set; }
        public int IdSportiste { get; set; }
        public double LicniRekord { get; set; }
        /* public virtual int IdTakmiciSe { get; protected set; }
        public virtual Disciplina SifraDiscipline { get; set; }
        public virtual Sportista IdSportiste { get; set; }
        public virtual double LicniRekord { get; set; }*/

        public TakmiciSePregled(int Id,int SifraDiscipline,int IdSportiste, double LicniRekord)
        {
            this.Id = Id;
            this.SifraDiscipline = SifraDiscipline;
            this.IdSportiste = IdSportiste;
            this.LicniRekord = LicniRekord;
        }
    }
    public class SudijePregled
    {
        public string Zemlja { get; set; }
        public string LicnoIme { get; set; }
        public string Prezime { get; set; }
        public int Id { get; set; }
        public string Specijalnost { get; set; }

        public SudijePregled(string Zemlja,string LicnoIme,string Prezime,int Id,string Specijalnost)
        {
            this.Zemlja = Zemlja;
            this.LicnoIme = LicnoIme;
            this.Prezime = Prezime;
            this.Id = Id;
            this.Specijalnost = Specijalnost;
        }
    }

    public class DisciplinePregled
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Tip { get; set; }
        public double? SvetskiRekord { get; set; }
        public double? OlimpijskiRekord { get; set; }
        public double? ProslogodisnjiRezultat { get; set; }
        public string SvetskiSampion { get; set; }
        public string OlimpijskiSampion { get; set; }

        public DisciplinePregled(int Id, string Ime, string Tip, double SvetskiRekord, double OlimpijskiRekord, double ProslogodisnjiRezultat, string SvetskiSampion, string OlimpijskiSampion)
        {
            this.Id = Id;
            this.Ime = Ime;
            this.Tip = Tip;
            this.SvetskiRekord = SvetskiRekord;
            this.OlimpijskiRekord = OlimpijskiRekord;
            this.ProslogodisnjiRezultat = ProslogodisnjiRezultat;
            this.SvetskiSampion = SvetskiSampion;
            this.OlimpijskiSampion = OlimpijskiSampion;
        }
    }

    public class RezultatiPregled
    {
        public int Id { get; set; }
        public int SifraDiscipline { get; set; }
        public string SkracenicaZemlje { get; set; }
        public string DatumPostizanja { get; set; }
        public double? RezultatZemlje { get; set; }

        public RezultatiPregled(int Id,int SifraDiscipline,string SkracenicaZemlje,string DatumPostizanja,double RezultatZemlje)
        {
            this.Id = Id;
            this.SifraDiscipline = SifraDiscipline;
            this.SkracenicaZemlje = SkracenicaZemlje;
            this.DatumPostizanja = DatumPostizanja;
            this.RezultatZemlje = RezultatZemlje;
        }

       
    }
    public class UcestvujePregled
    {
        public int ID { get; set; }
        public int IdSportiste { get; set; }
        public int IdTakmicenja { get; set; }
        public int Mesto { get; set; }
        public string Medalja { get; set; }

        public UcestvujePregled(int ID,int IdSportiste,int IdTakmicenja,int Mesto,string Medalja)
        {
            this.ID = ID;
            this.IdSportiste = IdSportiste;
            this.IdTakmicenja = IdTakmicenja;
            this.Mesto = Mesto;
            this.Medalja = Medalja;
        }
    }

    public class SudiNaPregled
    {
        public int IdSudije { get; set; }
        public int IdTakmicenja { get; set; }

        public SudiNaPregled(int IdSudije,int IdTakmicenja)
        {
            this.IdSudije = IdSudije;
            this.IdTakmicenja = IdTakmicenja;
        }
    }

    public class ZemljaPregled
    {
        public string JednistvenaSkracenica { get; set; }
        public string Ime { get; set; }
        public string Kontinent { get; set; }

        public ZemljaPregled(string JednistvenaSkracenica,string Ime,string Kontinent)
        {
            this.JednistvenaSkracenica = JednistvenaSkracenica;
            this.Ime = Ime;
            this.Kontinent = Kontinent;
        }
    }
}
