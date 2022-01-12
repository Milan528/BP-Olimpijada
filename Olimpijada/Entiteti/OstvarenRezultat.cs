using Olimpijada.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class OstvarenRezultat
    {
        #region Atributi
        public virtual int IdOstvarenRezultat { get; set; }
        public virtual Disciplina SifraDiscipline { get; set; }
        public virtual Zemlja SkracenicaZemlje { get; set; }
        public virtual DateTime? DatumPostizanja { get; set; }
        public virtual double? RezultatZemlje { get; set; }
        #endregion

        public OstvarenRezultat(int Id,Disciplina disc,Zemlja skr,DateTime datum,double rez)
        {
            this.IdOstvarenRezultat = Id;
            this.SifraDiscipline = disc;
            this.SkracenicaZemlje = skr;
            this.DatumPostizanja = datum;
            this.RezultatZemlje = rez;

        }

        public OstvarenRezultat()
        {
        }
    }
}
