using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class ImaDisciplinuId
    {
        public virtual Disciplina SifraDiscipline { get; set; }
        public virtual Sport IdSporta { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(ImaDisciplinuId))
                return false;

            ImaDisciplinuId receivedObject = (ImaDisciplinuId)obj;

            if((SifraDiscipline.Id==receivedObject.SifraDiscipline.Id) && (IdSporta.ID==receivedObject.IdSporta.ID))
                return true;

            return false;
            
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
