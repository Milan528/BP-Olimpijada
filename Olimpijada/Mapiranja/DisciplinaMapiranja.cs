using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    class DisciplinaMapiranja : ClassMap<Olimpijada.Entiteti.Disciplina>
    {
        public DisciplinaMapiranja()
        {
            Table("DISCIPLINA");

            Id(x => x.Id, "SIFRA").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime).Column("IME").Length(30);
            Map(x => x.TipDiscipline).Column("TIP_DISCIPLINE").Length(20);
            Map(x => x.SvetskiRekord).Column("SVETSKI_REKORD").Length(20);
            Map(x => x.OlimpijskiRekord).Column("OLIMPIJSKI_REKORD").Length(20);
            Map(x => x.ProslogodisnjiRezultat).Column("PROSLOGODISNJI_REZULTAT").Length(20);
            Map(x => x.SvetskiPrvak).Column("SVETSKI_PRVAK").Length(30);
            Map(x => x.OlimpijskiPrvak).Column("OLIMPIJSKI_PRVAK").Length(30);

            HasMany(x => x.TakmiceSe).KeyColumn("SIFRA_DISCIPLINE").LazyLoad().Cascade.All().Inverse();
              HasManyToMany(x => x.Sportovi)
                   .Table("IMA_DISCIPLINU")
                   .ParentKeyColumn("SIFRA_DISCIPLINE")
                   .ChildKeyColumn("ID_SPORTA")
                   .Inverse()
                   .Cascade.All();

            HasManyToMany(x => x.Zemlje)
                  .Table("IMA_DISCIPLINU")
                  .ParentKeyColumn("SIFRA_DISCIPLINE")
                  .ChildKeyColumn("SKRACENICA_ZEMLJE");
                  

            HasMany(x => x.OdrzavaSe).KeyColumn("SIFRA_DISCIPLINE").LazyLoad().Cascade.All().Inverse();

      

        }
    }
}
