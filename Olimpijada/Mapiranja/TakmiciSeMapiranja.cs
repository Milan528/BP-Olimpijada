using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    public class TakmiciSeMapiranja : ClassMap<Olimpijada.Entiteti.TakmiciSe>
    {
        public TakmiciSeMapiranja()
        {
            Table("TAKMICI_SE");

            Id(x => x.IdTakmiciSe, "ID_TAKMICI_SE").GeneratedBy.TriggerIdentity();

            References(x => x.SifraDiscipline, "SIFRA_DISCIPLINE");
            References(x => x.IdSportiste, "ID_SPORTISTE");
            Map(x => x.LicniRekord, "LICNI_REKORD");
        }
    }
}
