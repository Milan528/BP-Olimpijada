using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olimpijada.Entiteti
{
    public class Zemlja
    {
        
        public virtual string JedinstvenaSkracenica { get; set; }
        public virtual string Kontinent { get; set; }
        public virtual string Ime { get; set; }
       
        public virtual IList<OstvarenRezultat> OstvareniRezultati { get; set; }
        public virtual IList<Disciplina> Discipline { get; set; }
    

        public Zemlja()
        {
            Discipline = new List<Disciplina>();
            OstvareniRezultati = new List<OstvarenRezultat>();
        }
    }
}
