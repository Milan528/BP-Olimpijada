using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class SudiNaId
    {
        public virtual Takmicenje IdTakmicenja { get; set; }
        public virtual Sudija IdSudije { get; set; }


        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(SudiNaId))
                return false;

           SudiNaId receivedObject = (SudiNaId)obj;

            if ((IdSudije.IdSudije == receivedObject.IdSudije.IdSudije) && (IdTakmicenja.ID== receivedObject.IdTakmicenja.ID))
                return true;

            return false;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
