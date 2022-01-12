using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Entiteti
{
    class SportMapiranja : ClassMap<Olimpijada.Entiteti.Sport>
    {
        public SportMapiranja()
        {
            Table("SPORT");

            //Id(x => x.ID).Column("ID_SPORT").GeneratedBy.Custom("trigger-identity");
            Id(x => x.ID, "ID_SPORT").GeneratedBy.TriggerIdentity();
           
            Map(x => x.TipSporta, "TIP_SPORTA").Length(30);
            Map(x => x.BrojDiscipline, "BROJ_DISCIPLINE").Length(3);
            Map(x => x.Naziv, "NAZIV").Length(30);
            Map(x => x.MSA, "MSA").Length(30);

            HasManyToMany(x => x.Disciplinas)
                .Table("IMA_DISCIPLINU")
                .ParentKeyColumn("ID_SPORTA")
                .ChildKeyColumn("SIFRA_DISCIPLINE");


            HasMany(x => x.ImaDiscipline).KeyColumn("ID_SPORTA").LazyLoad();//.Cascade.All().Inverse();

    
        }
    }
}
