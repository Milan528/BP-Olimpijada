using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;


namespace Olimpijada.Mapiranja
{
    public class SudiNaMapiranja : ClassMap<Olimpijada.Entiteti.SudiNa>
    {
        public SudiNaMapiranja()
        {
            Table("SUDI_NA");



            CompositeId(x => x.Id)
             .KeyReference(x => x.IdSudije, "ID_SUDIJE")
             .KeyReference(x => x.IdTakmicenja, "ID_TAKMICENJA");
        }
    }
}
