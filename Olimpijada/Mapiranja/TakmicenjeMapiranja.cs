using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olimpijada.Entiteti;
using FluentNHibernate.Mapping;

namespace Olimpijada.Mapiranja
{
    public class TakmicenjeMapiranja : ClassMap<Olimpijada.Entiteti.Takmicenje>
    {
        public TakmicenjeMapiranja()
        {
            Table("TAKMICENJE");

           

            Map(x => x.NazivStadiona, "NAZIV_STADIONA");
            Map(x => x.VremeOdrzavanja, "VREME_ODRZAVANJA");
            Map(x => x.DatumOdrzavanja, "DATUM_ODRZAVANJA");

            Id(x => x.ID, "ID_TAKMICENJE").GeneratedBy.TriggerIdentity();

            HasManyToMany(x => x.Sudije)
               .Table("SUDI_NA")
               .ParentKeyColumn("ID_TAKMICENJA")
               .ChildKeyColumn("ID_SUDIJE");
              

            HasManyToMany(x => x.Discipline)
              .Table("ODRZAVA_SE")
              .ParentKeyColumn("ID_TAKMICENJA")
              .ChildKeyColumn("SIFRA_DISCIPLINE");


            HasManyToMany(x => x.Sportisti)
              .Table("UCESTVUJE")
              .ParentKeyColumn("ID_TAKMICENJA")
              .ChildKeyColumn("ID_SPORTISTE");

            HasMany(x => x.Ucesnici).KeyColumn("ID_TAKMICENJA").LazyLoad();//.Cascade.All().Inverse();

            HasMany(x => x.SudiNa).KeyColumn("ID_TAKMICENJA").LazyLoad();//.Cascade.All().Inverse();
            HasMany(x => x.OdrzavaSe).KeyColumn("ID_TAKMICENJA").LazyLoad();//.Cascade.All().Inverse();
           
        
        }
    }
    
    
}
