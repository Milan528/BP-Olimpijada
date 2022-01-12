using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;
namespace Olimpijada.Mapiranja
{
    public class ZemljaMapiranja:ClassMap<Zemlja>
    {

        public ZemljaMapiranja()
        {
            Table("ZEMLJA");

            Id(x => x.JedinstvenaSkracenica,"JEDINSTVENA_SKRACENICA").GeneratedBy.Assigned();

            Map(x => x.Kontinent,"KONTINENT");
            Map(x => x.Ime,"IME").Length(48);


            HasManyToMany(x => x.Discipline)
               .Table("OSTVAREN_REZULTAT")
               .ParentKeyColumn("SKRACENICA_ZEMLJE")
               .ChildKeyColumn("SIFRA_DISCIPLINE")
               .Inverse()
               .Cascade.All();

            HasMany(x => x.OstvareniRezultati).KeyColumn("SKRACENICA_ZEMLJE").LazyLoad();//.Cascade.All().Inverse();



        }
    }
}
