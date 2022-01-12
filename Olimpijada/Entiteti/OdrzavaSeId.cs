using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpijada.Entiteti
{
    public class OdrzavaSeId
    {
        public virtual Takmicenje IdTakmicenje { get; set; }
        public virtual Disciplina IdDiscipline { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(OdrzavaSeId))
                return false;

            OdrzavaSeId receivedObject = (OdrzavaSeId)obj;

            if ((IdTakmicenje.ID == receivedObject.IdTakmicenje.ID) && (IdDiscipline.Id == receivedObject.IdDiscipline.Id))
                return true;

            return false;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
