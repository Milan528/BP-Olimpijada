using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class Takmicenje
    {
        #region Atributi
       
       
        public virtual String NazivStadiona { get; set; }
        public virtual String VremeOdrzavanja { get; set; }
        public virtual DateTime DatumOdrzavanja { get; set; }
        public virtual int ID { get; protected set; }
        public virtual IList<Sportista> Sportisti { get; set; }
        public virtual IList<Ucestvuje> Ucesnici { get; set; }

        public virtual IList<Disciplina> Discipline { get; set; }
        public virtual IList<Sudija> Sudije { get; set; }


        public virtual IList<SudiNa> SudiNa { get; set; }
        public virtual IList<OdrzavaSe> OdrzavaSe { get; set; }


        #endregion



        public Takmicenje()
          {
             Sudije = new List<Sudija>();
           
            Sportisti = new List<Sportista>();
            Ucesnici = new List<Ucestvuje>();
            Discipline = new List<Disciplina>();

            SudiNa = new List<SudiNa>();
            OdrzavaSe = new List<OdrzavaSe>();
        }
    }
}
