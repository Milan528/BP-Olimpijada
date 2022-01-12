using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class ImaDisciplinu
    {
        public virtual ImaDisciplinuId Id{ get; set; }

        public ImaDisciplinu()
        {
            Id = new ImaDisciplinuId();
        }
    }
}
