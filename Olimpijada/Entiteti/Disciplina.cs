using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class Disciplina
    {
        #region Atributi
        public virtual int Id { get;  set; }
        public virtual string Ime { get; set; }
        public virtual string TipDiscipline { get; set; }
        public virtual double? SvetskiRekord { get; set; }
        public virtual double? OlimpijskiRekord { get; set; }
        public virtual double? ProslogodisnjiRezultat { get; set; }
        public virtual string SvetskiPrvak { get; set; }
        public virtual string OlimpijskiPrvak { get; set; }
         public virtual IList<Sport> Sportovi { get; set; }
        /*public virtual IList<ImaDisciplinu> ImaDiscipline { get; set; }*/
        public virtual IList<TakmiciSe> TakmiceSe { get; set; }
        public virtual IList<OdrzavaSe> OdrzavaSe { get; set; }

        public virtual IList<Zemlja> Zemlje { get; set; }



        #endregion



        public Disciplina()
        {
            Sportovi = new List<Sport>();
            Zemlje = new List<Zemlja>();
            TakmiceSe = new List<TakmiciSe>();
            OdrzavaSe = new List<OdrzavaSe>();
            
        }

    }
}
