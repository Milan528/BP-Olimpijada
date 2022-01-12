using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class Ucestvuje
    {
        public virtual int IdUcestvuje { get;  set; }
        public virtual Takmicenje IdTakmicenja { get; set; }
        public virtual Sportista IdSportiste { get; set; }
        public virtual int Mesto{ get; set; }
        public virtual string Medalja { get; set; }
        
    }
}
