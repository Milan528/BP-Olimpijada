using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    class ImaDisciplinuMapiranja : ClassMap<Olimpijada.Entiteti.ImaDisciplinu>
    {
        public ImaDisciplinuMapiranja()
        {
            Table("IMA_DISCIPLINU");

            CompositeId(x => x.Id)
                .KeyReference(x => x.IdSporta, "ID_SPORTA")
                .KeyReference(x => x.SifraDiscipline, "SIFRA_DISCIPLINE");


        }
    }
}
