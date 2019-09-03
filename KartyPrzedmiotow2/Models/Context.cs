namespace KartyPrzedmiotow2.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class Context : IdentityDbContext<Uzytkownik>
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KartyPrzedmiotow.Models.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context()
            : base("name=DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            base.OnModelCreating(dbModelBuilder);
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Efekt> Efekty { get; set; }
        public DbSet<FormaZaliczenia> FormyZaliczenia { get; set; }
        public DbSet<GrupaPrzedmiotow> GrupyPrzedmiotow { get; set; }
        public DbSet<GrupyMetodDydaktycznych> GrupyMetodDydaktycznych { get; set; }
        public DbSet<Jezyk> JezykiObce { get; set; }
        public DbSet<Kierunek> Kierunki { get; set; }
        public DbSet<Literatura> Literatury { get; set; }
        public DbSet<Material> Materialy { get; set; }
        public DbSet<MetodyDydaktyczne> Metody { get; set; }
        public DbSet<ProgramMetodyDydaktyczne> ProgramMetody { get; set; }
        public DbSet<ProgramMetodyOceniania> ProgramMetodyOceniania { get; set; }
        public DbSet<MetodyOceniania> MetodyOceniania { get; set; }
        public DbSet<Poziom> Poziomy { get; set; }
        public DbSet<ProfilKsztalcenia> ProfileKsztalcenia { get; set; }
        public DbSet<Program> ProgramyStudiow { get; set; }
        public DbSet<PrzedmiotOpis> PrzedmiotOpisy { get; set; }
        public DbSet<Pytanie> Pytania { get; set; }
        public DbSet<RodzajEfektu> RodzajeEfektow { get; set; }
        public DbSet<Semestr> Semestry { get; set; }
        public DbSet<Specjalnosc> Specjalnosci { get; set; }
        public DbSet<Tresci> Tresci { get; set; }
        public DbSet<TypLiteratura> TypyLiteratury { get; set; }
        public DbSet<Tytul> Tytuly { get; set; }
        public DbSet<Wydzial> Wydzialy { get; set; }
        public DbSet<ObszarKsztalcenia> ObszaryKsztalcenia { get; set; }
        public DbSet<LiczbaGodzin> LiczbyGodzin { get; set; }
        public DbSet<TypLiczbaGodzin> TypyLiczbGodzin { get; set; }
        public DbSet<ProgramEfekt> ProgramEfekty { get; set; }
        public DbSet<ProgramEfektTresc> ProgramEfektTresci { get; set; }
        public DbSet<ProgramEfektMetodaDydaktyczna> ProgramEfektMetodaDydaktyczna { get; set; }
        public DbSet<ProgramEfektMetodaOceniania> ProgramEfektMetodaOceniania { get; set; }
        public DbSet<FormaPracy> FormyPracy { get; set; }
        public DbSet<ProgramFormaPracyGodzina> ProgramFormaPracyGodziny { get; set; }

        //public DbSet<SpecjalnoscListElement> SpecjalnosciListElements { get; set; }
        //public DbSet<KierunekListElement> KierunkiListElements { get; set; }
        //public DbSet<UzytkownikListElement> UzytkownicyListElements { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}