using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    public class SudijaMapiranja : ClassMap<Olimpijada.Entiteti.Sudija>
    {
        public SudijaMapiranja()
        {
            Table("SUDIJA");

            Id(x => x.IdSudije, "ID_SUDIJA").GeneratedBy.TriggerIdentity();

            Map(x => x.Zemlja, "ZEMLJA");
            Map(x => x.LicnoIme, "LICNO_IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Specijalnost, "SPECIJALNOST");

            HasManyToMany(x => x.Takmicenja)
              .Table("SUDI_NA")
              .ParentKeyColumn("ID_SUDIJE")
              .ChildKeyColumn("ID_TAKMICENJA");


            HasMany(x => x.SudiNa).KeyColumn("ID_SUDIJE").LazyLoad();//.Cascade.All().Inverse();
        }
    }
}
