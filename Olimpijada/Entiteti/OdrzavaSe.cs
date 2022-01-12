using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class OdrzavaSe
    {
        public virtual OdrzavaSeId OdrzavaSeId { get; set; }

        public OdrzavaSe()
        {
            OdrzavaSeId = new OdrzavaSeId();
        }
    }
}
