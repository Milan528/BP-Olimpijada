using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Olimpijada.Entiteti;

namespace Olimpijada.Mapiranja
{
    class SportistaMapiranja : ClassMap<Olimpijada.Entiteti.Sportista>
    {
        public SportistaMapiranja()
        {
            Table("SPORTISTA");

            Id(x => x.IdSportista, "ID_SPORTISTA").GeneratedBy.TriggerIdentity();

            Map(x => x.Zemlja,"ZEMLJA");
            Map(x => x.LicnoIme,"LICNO_IME");
            Map(x => x.Prezime,"PREZIME");
            Map(x => x.Inicijali,"INICIJALI");
            References(x => x.PredstavljaZemlju, "PREDSTAVLJA_ZEMLJU");

            HasManyToMany(x => x.Takmicenja)
               .Table("UCESTVUJE")
               .ParentKeyColumn("ID_SPORTISTE")
               .ChildKeyColumn("ID_TAKMICENJA");

            HasMany(x => x.TakmiciSeU).KeyColumn("ID_SPORTISTE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Ucestvovanja).KeyColumn("ID_SPORTISTE").LazyLoad();//.Cascade.All();//.Inverse();
        }
    }
}

