using Olimpijada.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class Sport
    {
        #region Atributi
       
        public virtual int BrojDiscipline { get; set; }
        public virtual string TipSporta { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string MSA { get; set; }
        public virtual int ID { get; set; }

        public virtual IList<ImaDisciplinu> ImaDiscipline { get; set; }
        public virtual IList<Disciplina> Disciplinas { get; set; }
        #endregion



        public Sport()
        {
          
           ImaDiscipline = new List<ImaDisciplinu>();
            Disciplinas = new List<Disciplina>();
        }
        

    }
}
