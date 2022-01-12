using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    public class OdrzavaSeMapiranja : ClassMap<Olimpijada.Entiteti.OdrzavaSe>
    {
        public OdrzavaSeMapiranja()
        {
            Table("ODRZAVA_SE");

            CompositeId(x => x.OdrzavaSeId)
             .KeyReference(x => x.IdTakmicenje, "ID_TAKMICENJA")
             .KeyReference(x => x.IdDiscipline, "SIFRA_DISCIPLINE");
        }
    }
}
