using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    public class OstvarenRezultatMapiranja : ClassMap<Olimpijada.Entiteti.OstvarenRezultat>
    {
        public OstvarenRezultatMapiranja()
        {
            Table("OSTVAREN_REZULTAT");

            Id(x => x.IdOstvarenRezultat,"ID_OSTVAREN_REZULTAT").GeneratedBy.TriggerIdentity();
           
           
            Map(x => x.DatumPostizanja,"DATUM_POSTIZANJA");
            Map(x => x.RezultatZemlje,"REZULTAT_ZEMLJE");
            References(x => x.SifraDiscipline,"SIFRA_DISCIPLINE");
            References(x => x.SkracenicaZemlje,"SKRACENICA_ZEMLJE");





        }
    }
}
