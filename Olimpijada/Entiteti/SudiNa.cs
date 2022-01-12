using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Olimpijada.Entiteti
{
    public class SudiNa
    {
        public virtual SudiNaId Id { get; set; }
        

        public SudiNa() { Id = new SudiNaId(); }

    }
}
