using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class TakmiciSe
    {
        #region Atributi

        public virtual int IdTakmiciSe { get; protected set; }
        public virtual Disciplina SifraDiscipline { get; set; }
        public virtual Sportista IdSportiste { get; set; }
        public virtual double LicniRekord { get; set; }

        #endregion


    }
}
