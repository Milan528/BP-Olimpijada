using Olimpijada.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class Sudija
    {
        #region Atributi
        public virtual string Zemlja { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int IdSudije { get; protected set; }
        public virtual string Specijalnost { get; set; }

        public virtual IList<Takmicenje> Takmicenja{get;set;}
        public virtual IList<SudiNa> SudiNa { get; set; }
        #endregion



        public Sudija()
        {
            
            SudiNa = new List<SudiNa>();
            Takmicenja = new List<Takmicenje>();
        }
    }
}
