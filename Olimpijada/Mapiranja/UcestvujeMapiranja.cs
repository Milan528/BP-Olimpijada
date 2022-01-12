using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    public class UcestvujeMapiranja : ClassMap<Olimpijada.Entiteti.Ucestvuje>
    {
        public UcestvujeMapiranja()
        {
            Table("UCESTVUJE");

            Id(x => x.IdUcestvuje, "ID_UCESTVUJE").GeneratedBy.TriggerIdentity();

            References(x => x.IdTakmicenja, "ID_TAKMICENJA");
            References(x => x.IdSportiste, "ID_SPORTISTE");
            Map(x => x.Mesto, "MESTO");
            Map(x => x.Medalja, "MEDALJA");
            
        }
    }
}
