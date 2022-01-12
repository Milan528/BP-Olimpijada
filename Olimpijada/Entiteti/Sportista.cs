using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olimpijada.Entiteti
{
    public class Sportista
    {
        public virtual string Zemlja { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Inicijali { get; set; }
        public virtual int IdSportista { get;  set; }
        public virtual Zemlja PredstavljaZemlju { get; set; }


        public virtual IList<Takmicenje> Takmicenja { get; set; }
        public virtual IList<Ucestvuje> Ucestvovanja { get; set; }
        public virtual IList<TakmiciSe> TakmiciSeU { get; set; }
        public Sportista()
        {
           
            Ucestvovanja = new List<Ucestvuje>();
            TakmiciSeU = new List<TakmiciSe>();
            Takmicenja = new List<Takmicenje>();

        }
    }
}
