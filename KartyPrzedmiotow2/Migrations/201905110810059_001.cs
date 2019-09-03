namespace KartyPrzedmiotow2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Efekt",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Skrot = c.String(),
                        Opis = c.String(),
                        RodzajEfektuId = c.Int(nullable: false),
                        PoziomId = c.Int(nullable: false),
                        WydzialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Poziom", t => t.PoziomId, cascadeDelete: true)
                .ForeignKey("dbo.RodzajEfektu", t => t.RodzajEfektuId, cascadeDelete: true)
                .ForeignKey("dbo.Wydzial", t => t.WydzialId, cascadeDelete: true)
                .Index(t => t.RodzajEfektuId)
                .Index(t => t.PoziomId)
                .Index(t => t.WydzialId);
            
            CreateTable(
                "dbo.Poziom",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Program",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Kod = c.String(),
                        PrzedmiotDoWyboru = c.Boolean(nullable: false),
                        ECTS = c.Int(nullable: false),
                        WarunkiZaliczenia = c.String(),
                        WykladowcaId = c.String(maxLength: 128),
                        FormaZaliczeniaId = c.Int(nullable: false),
                        SpecjalnoscId = c.Int(nullable: false),
                        SemestrId = c.Int(nullable: false),
                        GrupaPrzedmiotowId = c.Int(nullable: false),
                        ObszarKsztalceniaId = c.Int(nullable: false),
                        ProfilKsztalceniaId = c.Int(nullable: false),
                        PoziomId = c.Int(nullable: false),
                        KierunekId = c.Int(nullable: false),
                        WydzialId = c.Int(nullable: false),
                        Usuniety = c.DateTime(),
                        PrzedmiotOpis_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormaZaliczenia", t => t.FormaZaliczeniaId, cascadeDelete: true)
                .ForeignKey("dbo.GrupaPrzedmiotow", t => t.GrupaPrzedmiotowId, cascadeDelete: true)
                .ForeignKey("dbo.Kierunek", t => t.KierunekId, cascadeDelete: true)
                .ForeignKey("dbo.ObszarKsztalcenia", t => t.ObszarKsztalceniaId, cascadeDelete: true)
                .ForeignKey("dbo.Poziom", t => t.PoziomId, cascadeDelete: true)
                .ForeignKey("dbo.ProfilKsztalcenia", t => t.ProfilKsztalceniaId, cascadeDelete: true)
                .ForeignKey("dbo.PrzedmiotOpis", t => t.PrzedmiotOpis_Id)
                .ForeignKey("dbo.Semestr", t => t.SemestrId, cascadeDelete: true)
                .ForeignKey("dbo.Specjalnosc", t => t.SpecjalnoscId, cascadeDelete: true)
                .ForeignKey("dbo.Wydzial", t => t.WydzialId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.WykladowcaId)
                .Index(t => t.WykladowcaId)
                .Index(t => t.FormaZaliczeniaId)
                .Index(t => t.SpecjalnoscId)
                .Index(t => t.SemestrId)
                .Index(t => t.GrupaPrzedmiotowId)
                .Index(t => t.ObszarKsztalceniaId)
                .Index(t => t.ProfilKsztalceniaId)
                .Index(t => t.PoziomId)
                .Index(t => t.KierunekId)
                .Index(t => t.WydzialId)
                .Index(t => t.PrzedmiotOpis_Id);
            
            CreateTable(
                "dbo.ProgramEfekt",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WymaganiaWstepne = c.Boolean(nullable: false),
                        PrzedmiotoweEfektyKsztalcenia = c.String(),
                        ProgramId = c.Int(nullable: false),
                        EfektId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Efekt", t => t.EfektId)
                .ForeignKey("dbo.Program", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId)
                .Index(t => t.EfektId);
            
            CreateTable(
                "dbo.ProgramEfektMetodaDydaktyczna",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProgramMetodyDydaktyczneId = c.Int(),
                        ProgramEfektId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProgramEfekt", t => t.ProgramEfektId, cascadeDelete: true)
                .ForeignKey("dbo.ProgramMetodyDydaktyczne", t => t.ProgramMetodyDydaktyczneId)
                .Index(t => t.ProgramMetodyDydaktyczneId)
                .Index(t => t.ProgramEfektId);
            
            CreateTable(
                "dbo.ProgramMetodyDydaktyczne",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Skrot = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        MetodyDydaktyczneId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MetodyDydaktyczne", t => t.MetodyDydaktyczneId, cascadeDelete: true)
                .ForeignKey("dbo.Program", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId)
                .Index(t => t.MetodyDydaktyczneId);
            
            CreateTable(
                "dbo.MetodyDydaktyczne",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        GrupyMetodDydaktycznychId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GrupyMetodDydaktycznych", t => t.GrupyMetodDydaktycznychId, cascadeDelete: true)
                .Index(t => t.GrupyMetodDydaktycznychId);
            
            CreateTable(
                "dbo.GrupyMetodDydaktycznych",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramEfektMetodaOceniania",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProgramMetodyOcenianiaId = c.Int(),
                        ProgramEfektId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProgramEfekt", t => t.ProgramEfektId, cascadeDelete: true)
                .ForeignKey("dbo.ProgramMetodyOceniania", t => t.ProgramMetodyOcenianiaId)
                .Index(t => t.ProgramMetodyOcenianiaId)
                .Index(t => t.ProgramEfektId);
            
            CreateTable(
                "dbo.ProgramMetodyOceniania",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Skrot = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        MetodyOcenianiaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MetodyOceniania", t => t.MetodyOcenianiaId, cascadeDelete: true)
                .ForeignKey("dbo.Program", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId)
                .Index(t => t.MetodyOcenianiaId);
            
            CreateTable(
                "dbo.MetodyOceniania",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramEfektTresc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TresciId = c.Int(),
                        ProgramEfektId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProgramEfekt", t => t.ProgramEfektId, cascadeDelete: true)
                .ForeignKey("dbo.Tresci", t => t.TresciId)
                .Index(t => t.TresciId)
                .Index(t => t.ProgramEfektId);
            
            CreateTable(
                "dbo.Tresci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                        Skrot = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        TypLiczbaGodzinId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Program", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.TypLiczbaGodzin", t => t.TypLiczbaGodzinId, cascadeDelete: true)
                .Index(t => t.ProgramId)
                .Index(t => t.TypLiczbaGodzinId);
            
            CreateTable(
                "dbo.TypLiczbaGodzin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LiczbaGodzin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Stacjonarne = c.Int(nullable: false),
                        Niestacjonarne = c.Int(nullable: false),
                        TypLiczbaGodzinId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Program", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.TypLiczbaGodzin", t => t.TypLiczbaGodzinId, cascadeDelete: true)
                .Index(t => t.TypLiczbaGodzinId)
                .Index(t => t.ProgramId);
            
            CreateTable(
                "dbo.ProgramFormaPracyGodzina",
                c => new
                    {
                        FormaPracyGodzinaId = c.Int(nullable: false, identity: true),
                        Godzin = c.Int(nullable: false),
                        Dzienna = c.Boolean(nullable: false),
                        FormaPracyId = c.Int(nullable: false),
                        LiczbaGodzinId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FormaPracyGodzinaId)
                .ForeignKey("dbo.FormaPracy", t => t.FormaPracyId, cascadeDelete: true)
                .ForeignKey("dbo.LiczbaGodzin", t => t.LiczbaGodzinId, cascadeDelete: true)
                .Index(t => t.FormaPracyId)
                .Index(t => t.LiczbaGodzinId);
            
            CreateTable(
                "dbo.FormaPracy",
                c => new
                    {
                        FormaPracyId = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.FormaPracyId);
            
            CreateTable(
                "dbo.FormaZaliczenia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GrupaPrzedmiotow",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kierunek",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                        WydzialId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Wydzial", t => t.WydzialId)
                .Index(t => t.WydzialId);
            
            CreateTable(
                "dbo.Specjalnosc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                        KierunekId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kierunek", t => t.KierunekId)
                .Index(t => t.KierunekId);
            
            CreateTable(
                "dbo.Wydzial",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UzytkownikWydzialy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WydzialId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .ForeignKey("dbo.Wydzial", t => t.WydzialId, cascadeDelete: true)
                .Index(t => t.WydzialId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Tytul",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Kolejnosc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ObszarKsztalcenia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfilKsztalcenia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrzedmiotOpis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaAngielski = c.String(),
                        Rok = c.String(),
                        KrotkiOpis = c.String(),
                        Wykladowca = c.String(),
                        CelGlowny = c.String(),
                        CelWiedza = c.String(),
                        CelUmiejetnosci = c.String(),
                        CelKompetencje = c.String(),
                        JezykiId = c.Int(nullable: false),
                        MaterialyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jezyk", t => t.JezykiId, cascadeDelete: true)
                .ForeignKey("dbo.Material", t => t.MaterialyId, cascadeDelete: true)
                .Index(t => t.JezykiId)
                .Index(t => t.MaterialyId);
            
            CreateTable(
                "dbo.Jezyk",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Literatura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        TypLiteratura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypLiteratura", t => t.TypLiteratura_Id)
                .Index(t => t.TypLiteratura_Id);
            
            CreateTable(
                "dbo.TypLiteratura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Wykladowca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pytanie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semestr",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RodzajEfektu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.TytulUzytkownik",
                c => new
                    {
                        Tytul_Id = c.Int(nullable: false),
                        Uzytkownik_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Tytul_Id, t.Uzytkownik_Id })
                .ForeignKey("dbo.Tytul", t => t.Tytul_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Uzytkownik_Id, cascadeDelete: true)
                .Index(t => t.Tytul_Id)
                .Index(t => t.Uzytkownik_Id);
            
            CreateTable(
                "dbo.LiteraturaPrzedmiotOpis",
                c => new
                    {
                        Literatura_Id = c.Int(nullable: false),
                        PrzedmiotOpis_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Literatura_Id, t.PrzedmiotOpis_Id })
                .ForeignKey("dbo.Literatura", t => t.Literatura_Id, cascadeDelete: true)
                .ForeignKey("dbo.PrzedmiotOpis", t => t.PrzedmiotOpis_Id, cascadeDelete: true)
                .Index(t => t.Literatura_Id)
                .Index(t => t.PrzedmiotOpis_Id);
            
            CreateTable(
                "dbo.PytanieProgram",
                c => new
                    {
                        Pytanie_Id = c.Int(nullable: false),
                        Program_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pytanie_Id, t.Program_Id })
                .ForeignKey("dbo.Pytanie", t => t.Pytanie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Program", t => t.Program_Id, cascadeDelete: true)
                .Index(t => t.Pytanie_Id)
                .Index(t => t.Program_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Efekt", "WydzialId", "dbo.Wydzial");
            DropForeignKey("dbo.Efekt", "RodzajEfektuId", "dbo.RodzajEfektu");
            DropForeignKey("dbo.Efekt", "PoziomId", "dbo.Poziom");
            DropForeignKey("dbo.Program", "WykladowcaId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Program", "WydzialId", "dbo.Wydzial");
            DropForeignKey("dbo.Program", "SpecjalnoscId", "dbo.Specjalnosc");
            DropForeignKey("dbo.Program", "SemestrId", "dbo.Semestr");
            DropForeignKey("dbo.PytanieProgram", "Program_Id", "dbo.Program");
            DropForeignKey("dbo.PytanieProgram", "Pytanie_Id", "dbo.Pytanie");
            DropForeignKey("dbo.Program", "PrzedmiotOpis_Id", "dbo.PrzedmiotOpis");
            DropForeignKey("dbo.PrzedmiotOpis", "MaterialyId", "dbo.Material");
            DropForeignKey("dbo.Literatura", "TypLiteratura_Id", "dbo.TypLiteratura");
            DropForeignKey("dbo.LiteraturaPrzedmiotOpis", "PrzedmiotOpis_Id", "dbo.PrzedmiotOpis");
            DropForeignKey("dbo.LiteraturaPrzedmiotOpis", "Literatura_Id", "dbo.Literatura");
            DropForeignKey("dbo.PrzedmiotOpis", "JezykiId", "dbo.Jezyk");
            DropForeignKey("dbo.Program", "ProfilKsztalceniaId", "dbo.ProfilKsztalcenia");
            DropForeignKey("dbo.Program", "PoziomId", "dbo.Poziom");
            DropForeignKey("dbo.Program", "ObszarKsztalceniaId", "dbo.ObszarKsztalcenia");
            DropForeignKey("dbo.Program", "KierunekId", "dbo.Kierunek");
            DropForeignKey("dbo.Kierunek", "WydzialId", "dbo.Wydzial");
            DropForeignKey("dbo.UzytkownikWydzialy", "WydzialId", "dbo.Wydzial");
            DropForeignKey("dbo.UzytkownikWydzialy", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.TytulUzytkownik", "Uzytkownik_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TytulUzytkownik", "Tytul_Id", "dbo.Tytul");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Specjalnosc", "KierunekId", "dbo.Kierunek");
            DropForeignKey("dbo.Program", "GrupaPrzedmiotowId", "dbo.GrupaPrzedmiotow");
            DropForeignKey("dbo.Program", "FormaZaliczeniaId", "dbo.FormaZaliczenia");
            DropForeignKey("dbo.ProgramEfektTresc", "TresciId", "dbo.Tresci");
            DropForeignKey("dbo.Tresci", "TypLiczbaGodzinId", "dbo.TypLiczbaGodzin");
            DropForeignKey("dbo.LiczbaGodzin", "TypLiczbaGodzinId", "dbo.TypLiczbaGodzin");
            DropForeignKey("dbo.LiczbaGodzin", "ProgramId", "dbo.Program");
            DropForeignKey("dbo.ProgramFormaPracyGodzina", "LiczbaGodzinId", "dbo.LiczbaGodzin");
            DropForeignKey("dbo.ProgramFormaPracyGodzina", "FormaPracyId", "dbo.FormaPracy");
            DropForeignKey("dbo.Tresci", "ProgramId", "dbo.Program");
            DropForeignKey("dbo.ProgramEfektTresc", "ProgramEfektId", "dbo.ProgramEfekt");
            DropForeignKey("dbo.ProgramEfekt", "ProgramId", "dbo.Program");
            DropForeignKey("dbo.ProgramEfektMetodaOceniania", "ProgramMetodyOcenianiaId", "dbo.ProgramMetodyOceniania");
            DropForeignKey("dbo.ProgramMetodyOceniania", "ProgramId", "dbo.Program");
            DropForeignKey("dbo.ProgramMetodyOceniania", "MetodyOcenianiaId", "dbo.MetodyOceniania");
            DropForeignKey("dbo.ProgramEfektMetodaOceniania", "ProgramEfektId", "dbo.ProgramEfekt");
            DropForeignKey("dbo.ProgramEfektMetodaDydaktyczna", "ProgramMetodyDydaktyczneId", "dbo.ProgramMetodyDydaktyczne");
            DropForeignKey("dbo.ProgramMetodyDydaktyczne", "ProgramId", "dbo.Program");
            DropForeignKey("dbo.ProgramMetodyDydaktyczne", "MetodyDydaktyczneId", "dbo.MetodyDydaktyczne");
            DropForeignKey("dbo.MetodyDydaktyczne", "GrupyMetodDydaktycznychId", "dbo.GrupyMetodDydaktycznych");
            DropForeignKey("dbo.ProgramEfektMetodaDydaktyczna", "ProgramEfektId", "dbo.ProgramEfekt");
            DropForeignKey("dbo.ProgramEfekt", "EfektId", "dbo.Efekt");
            DropIndex("dbo.PytanieProgram", new[] { "Program_Id" });
            DropIndex("dbo.PytanieProgram", new[] { "Pytanie_Id" });
            DropIndex("dbo.LiteraturaPrzedmiotOpis", new[] { "PrzedmiotOpis_Id" });
            DropIndex("dbo.LiteraturaPrzedmiotOpis", new[] { "Literatura_Id" });
            DropIndex("dbo.TytulUzytkownik", new[] { "Uzytkownik_Id" });
            DropIndex("dbo.TytulUzytkownik", new[] { "Tytul_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Literatura", new[] { "TypLiteratura_Id" });
            DropIndex("dbo.PrzedmiotOpis", new[] { "MaterialyId" });
            DropIndex("dbo.PrzedmiotOpis", new[] { "JezykiId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.UzytkownikWydzialy", new[] { "UserId" });
            DropIndex("dbo.UzytkownikWydzialy", new[] { "WydzialId" });
            DropIndex("dbo.Specjalnosc", new[] { "KierunekId" });
            DropIndex("dbo.Kierunek", new[] { "WydzialId" });
            DropIndex("dbo.ProgramFormaPracyGodzina", new[] { "LiczbaGodzinId" });
            DropIndex("dbo.ProgramFormaPracyGodzina", new[] { "FormaPracyId" });
            DropIndex("dbo.LiczbaGodzin", new[] { "ProgramId" });
            DropIndex("dbo.LiczbaGodzin", new[] { "TypLiczbaGodzinId" });
            DropIndex("dbo.Tresci", new[] { "TypLiczbaGodzinId" });
            DropIndex("dbo.Tresci", new[] { "ProgramId" });
            DropIndex("dbo.ProgramEfektTresc", new[] { "ProgramEfektId" });
            DropIndex("dbo.ProgramEfektTresc", new[] { "TresciId" });
            DropIndex("dbo.ProgramMetodyOceniania", new[] { "MetodyOcenianiaId" });
            DropIndex("dbo.ProgramMetodyOceniania", new[] { "ProgramId" });
            DropIndex("dbo.ProgramEfektMetodaOceniania", new[] { "ProgramEfektId" });
            DropIndex("dbo.ProgramEfektMetodaOceniania", new[] { "ProgramMetodyOcenianiaId" });
            DropIndex("dbo.MetodyDydaktyczne", new[] { "GrupyMetodDydaktycznychId" });
            DropIndex("dbo.ProgramMetodyDydaktyczne", new[] { "MetodyDydaktyczneId" });
            DropIndex("dbo.ProgramMetodyDydaktyczne", new[] { "ProgramId" });
            DropIndex("dbo.ProgramEfektMetodaDydaktyczna", new[] { "ProgramEfektId" });
            DropIndex("dbo.ProgramEfektMetodaDydaktyczna", new[] { "ProgramMetodyDydaktyczneId" });
            DropIndex("dbo.ProgramEfekt", new[] { "EfektId" });
            DropIndex("dbo.ProgramEfekt", new[] { "ProgramId" });
            DropIndex("dbo.Program", new[] { "PrzedmiotOpis_Id" });
            DropIndex("dbo.Program", new[] { "WydzialId" });
            DropIndex("dbo.Program", new[] { "KierunekId" });
            DropIndex("dbo.Program", new[] { "PoziomId" });
            DropIndex("dbo.Program", new[] { "ProfilKsztalceniaId" });
            DropIndex("dbo.Program", new[] { "ObszarKsztalceniaId" });
            DropIndex("dbo.Program", new[] { "GrupaPrzedmiotowId" });
            DropIndex("dbo.Program", new[] { "SemestrId" });
            DropIndex("dbo.Program", new[] { "SpecjalnoscId" });
            DropIndex("dbo.Program", new[] { "FormaZaliczeniaId" });
            DropIndex("dbo.Program", new[] { "WykladowcaId" });
            DropIndex("dbo.Efekt", new[] { "WydzialId" });
            DropIndex("dbo.Efekt", new[] { "PoziomId" });
            DropIndex("dbo.Efekt", new[] { "RodzajEfektuId" });
            DropTable("dbo.PytanieProgram");
            DropTable("dbo.LiteraturaPrzedmiotOpis");
            DropTable("dbo.TytulUzytkownik");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RodzajEfektu");
            DropTable("dbo.Semestr");
            DropTable("dbo.Pytanie");
            DropTable("dbo.Material");
            DropTable("dbo.TypLiteratura");
            DropTable("dbo.Literatura");
            DropTable("dbo.Jezyk");
            DropTable("dbo.PrzedmiotOpis");
            DropTable("dbo.ProfilKsztalcenia");
            DropTable("dbo.ObszarKsztalcenia");
            DropTable("dbo.Tytul");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UzytkownikWydzialy");
            DropTable("dbo.Wydzial");
            DropTable("dbo.Specjalnosc");
            DropTable("dbo.Kierunek");
            DropTable("dbo.GrupaPrzedmiotow");
            DropTable("dbo.FormaZaliczenia");
            DropTable("dbo.FormaPracy");
            DropTable("dbo.ProgramFormaPracyGodzina");
            DropTable("dbo.LiczbaGodzin");
            DropTable("dbo.TypLiczbaGodzin");
            DropTable("dbo.Tresci");
            DropTable("dbo.ProgramEfektTresc");
            DropTable("dbo.MetodyOceniania");
            DropTable("dbo.ProgramMetodyOceniania");
            DropTable("dbo.ProgramEfektMetodaOceniania");
            DropTable("dbo.GrupyMetodDydaktycznych");
            DropTable("dbo.MetodyDydaktyczne");
            DropTable("dbo.ProgramMetodyDydaktyczne");
            DropTable("dbo.ProgramEfektMetodaDydaktyczna");
            DropTable("dbo.ProgramEfekt");
            DropTable("dbo.Program");
            DropTable("dbo.Poziom");
            DropTable("dbo.Efekt");
        }
    }
}
