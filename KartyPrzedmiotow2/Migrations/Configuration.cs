namespace KartyPrzedmiotow2.Migrations
{
    using KartyPrzedmiotow2.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KartyPrzedmiotow2.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        public void PublicSeed(KartyPrzedmiotow2.Models.Context context)
        {
            Seed(context);
        }

        protected override void Seed(KartyPrzedmiotow2.Models.Context context)
        {
            context.ProfileKsztalcenia.AddOrUpdate(x => x.Id,
                new ProfilKsztalcenia() { Id = 1, Nazwa = "Praktyczny" },
                new ProfilKsztalcenia() { Id = 2, Nazwa = "Ogólnouczelniany" }
                );

            context.GrupyPrzedmiotow.AddOrUpdate(x => x.Id,
                new GrupaPrzedmiotow() { Id = 1, Nazwa = "Ogólnouczelniane" },
                new GrupaPrzedmiotow() { Id = 2, Nazwa = "Realizowane na innym kierunku" },
                new GrupaPrzedmiotow() { Id = 3, Nazwa = "Podstawowe" },
                new GrupaPrzedmiotow() { Id = 4, Nazwa = "Kierunkowe" },
                new GrupaPrzedmiotow() { Id = 5, Nazwa = "Wynikaj¹ce z organizacji studiów" },
                new GrupaPrzedmiotow() { Id = 6, Nazwa = "Specjalnoœciowe" }
                );
            context.Materialy.AddOrUpdate(x => x.Id,
                new Material() { Id = 1, Nazwa = "kurs e-learningowy" },
                new Material() { Id = 2, Nazwa = "skrypt" },
                new Material() { Id = 3, Nazwa = "materia³y na platformie" },
                new Material() { Id = 4, Nazwa = "brak" }
                );
            context.Semestry.AddOrUpdate(x => x.Id,
                new Semestr() { Id = 1, Nazwa = "I" },
                new Semestr() { Id = 2, Nazwa = "II" },
                new Semestr() { Id = 3, Nazwa = "III" },
                new Semestr() { Id = 4, Nazwa = "IV" },
                new Semestr() { Id = 5, Nazwa = "V" },
                new Semestr() { Id = 6, Nazwa = "VI" },
                new Semestr() { Id = 7, Nazwa = "VII" }
                );
            context.FormyZaliczenia.AddOrUpdate(x => x.Id,
                new FormaZaliczenia() { Id = 1, Nazwa = "z - zaliczenie bez oceny" },
                new FormaZaliczenia() { Id = 2, Nazwa = "Z - zaliczenie na ocenê" },
                new FormaZaliczenia() { Id = 3, Nazwa = "E - egzamin" }
                );
            context.GrupyMetodDydaktycznych.AddOrUpdate(x => x.Id,
                new GrupyMetodDydaktycznych() { Id = 1, Nazwa = "Podaj¹ce" },
                new GrupyMetodDydaktycznych() { Id = 2, Nazwa = "Problemowe" },
                new GrupyMetodDydaktycznych() { Id = 3, Nazwa = "Praktyczne" },
                new GrupyMetodDydaktycznych() { Id = 4, Nazwa = "Eksponuj¹ce" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 1, Nazwa = "wyk³ad informacyjny" },
                new MetodyDydaktyczne() { Id = 2, GrupyMetodDydaktycznychId = 1, Nazwa = "opis" },
                new MetodyDydaktyczne() { Id = 3, GrupyMetodDydaktycznychId = 1, Nazwa = "opowiadanie" },
                new MetodyDydaktyczne() { Id = 4, GrupyMetodDydaktycznychId = 1, Nazwa = "pogadanka" },
                new MetodyDydaktyczne() { Id = 5, GrupyMetodDydaktycznychId = 1, Nazwa = "objaœnienie" },
                new MetodyDydaktyczne() { Id = 6, GrupyMetodDydaktycznychId = 1, Nazwa = "praca ze Ÿród³em drukowanym" },
                new MetodyDydaktyczne() { Id = 7, GrupyMetodDydaktycznychId = 1, Nazwa = "praca ze Ÿród³em elektronicznym" },
                new MetodyDydaktyczne() { Id = 8, GrupyMetodDydaktycznychId = 1, Nazwa = "studium przypadku" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 2, Nazwa = "wyk³ad problemowy" },
                new MetodyDydaktyczne() { Id = 2, GrupyMetodDydaktycznychId = 2, Nazwa = "burza mózgów" },
                new MetodyDydaktyczne() { Id = 3, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda sytuacyjna" },
                new MetodyDydaktyczne() { Id = 4, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda inscenizacji" },
                new MetodyDydaktyczne() { Id = 5, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda symulacyjna" },
                new MetodyDydaktyczne() { Id = 6, GrupyMetodDydaktycznychId = 2, Nazwa = "dyskusja dydaktyczna" },
                new MetodyDydaktyczne() { Id = 7, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda badawcza" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 3, Nazwa = "æwiczenie praktyczne" },
                new MetodyDydaktyczne() { Id = 2, GrupyMetodDydaktycznychId = 3, Nazwa = "metoda laboratoryjna" },
                new MetodyDydaktyczne() { Id = 3, GrupyMetodDydaktycznychId = 3, Nazwa = "pomiar" },
                new MetodyDydaktyczne() { Id = 4, GrupyMetodDydaktycznychId = 3, Nazwa = "projekt" },
                new MetodyDydaktyczne() { Id = 5, GrupyMetodDydaktycznychId = 3, Nazwa = "wycieczka edukacyjna" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 4, Nazwa = "drama" },
                new MetodyDydaktyczne() { Id = 2, GrupyMetodDydaktycznychId = 4, Nazwa = "film" },
                new MetodyDydaktyczne() { Id = 3, GrupyMetodDydaktycznychId = 4, Nazwa = "sztuka teatralna" },
                new MetodyDydaktyczne() { Id = 4, GrupyMetodDydaktycznychId = 4, Nazwa = "wystawa" },
                new MetodyDydaktyczne() { Id = 5, GrupyMetodDydaktycznychId = 4, Nazwa = "pokaz" }
                );
            context.MetodyOceniania.AddOrUpdate(x => x.Id,
                new MetodyOceniania() { Id = 1, Nazwa = "kolokwium pisemne" },
                new MetodyOceniania() { Id = 2, Nazwa = "test kontrolny" },
                new MetodyOceniania() { Id = 3, Nazwa = "praca pisemna" },
                new MetodyOceniania() { Id = 4, Nazwa = "egzamin ustny" },
                new MetodyOceniania() { Id = 5, Nazwa = "egzamin pisemny" },
                new MetodyOceniania() { Id = 6, Nazwa = "praca projektowa" },
                new MetodyOceniania() { Id = 7, Nazwa = "sprawozdanie z æwiczeñ" },
                new MetodyOceniania() { Id = 8, Nazwa = "przygotowanie do zajêæ" },
                new MetodyOceniania() { Id = 9, Nazwa = "aktywnoœæ w trakcie zajêæ" }
                );
            context.ObszaryKsztalcenia.AddOrUpdate(x => x.Id,
                new ObszarKsztalcenia() { Id = 1, Nazwa = "Obszar nauk humanistycznych" },
                new ObszarKsztalcenia() { Id = 2, Nazwa = "Obszar nauk spo³ecznych" },
                new ObszarKsztalcenia() { Id = 3, Nazwa = "Obszar nauk œcis³ych" },
                new ObszarKsztalcenia() { Id = 4, Nazwa = "Obszar nauk przyrodniczych" },
                new ObszarKsztalcenia() { Id = 5, Nazwa = "Obszar nauk technicznych" },
                new ObszarKsztalcenia() { Id = 6, Nazwa = "Obszar nauk rolniczych, leœnych i weterynaryjnych" },
                new ObszarKsztalcenia() { Id = 7, Nazwa = "Obszar nauk medycznych i nauk o zdrowiu oraz nauk o kulturze fizycznej" },
                new ObszarKsztalcenia() { Id = 8, Nazwa = "Obszar sztuki" },
                new ObszarKsztalcenia() { Id = 9, Nazwa = "Dwuobszarowy" }
                );

            context.TypyLiteratury.AddOrUpdate(x => x.Id,
                new TypLiteratura() { Id = 1, Nazwa = "Podstawowa" },
                new TypLiteratura() { Id = 2, Nazwa = "Uzupelniajaca" },
                new TypLiteratura() { Id = 3, Nazwa = "Dodatkowe" }
                );

            context.TypyLiczbGodzin.AddOrUpdate(x => x.Id,
                new TypLiczbaGodzin() { Id = 1, Nazwa = "Wyklad" },
                new TypLiczbaGodzin() { Id = 2, Nazwa = "Konserwatorium" },
                new TypLiczbaGodzin() { Id = 3, Nazwa = "Æwiczenia" },
                new TypLiczbaGodzin() { Id = 4, Nazwa = "Laboratorium" },
                new TypLiczbaGodzin() { Id = 5, Nazwa = "Projekt" },
                new TypLiczbaGodzin() { Id = 6, Nazwa = "Seminarium" },
                new TypLiczbaGodzin() { Id = 7, Nazwa = "Praktyka/Obóz" }
                );

            context.JezykiObce.AddOrUpdate(x => x.Id,
                new Jezyk() { Id = 1, Nazwa = "Polski" },
                new Jezyk() { Id = 2, Nazwa = "Angielski" },
                new Jezyk() { Id = 3, Nazwa = "Niemiecki" },
                new Jezyk() { Id = 4, Nazwa = "Hiszpañski" }
                );

            var mgr = new Tytul() { Id = 1, Nazwa = "mgr", Kolejnosc = 2 };
            var inz = new Tytul() { Id = 2, Nazwa = "in¿.", Kolejnosc = 3 };
            var dr = new Tytul() { Id = 3, Nazwa = "dr", Kolejnosc=1 };
            var doc = new Tytul() { Id = 4, Nazwa = "doc", Kolejnosc = 0 };

            context.Tytuly.AddOrUpdate(x => x.Id,
                mgr, inz, dr, doc
                );

            var passwordHasher = new PasswordHasher();

            var dziekan = new IdentityRole("Dziekan");
            var admin = new IdentityRole("Admin");
            var wykladowca = new IdentityRole("Wyk³adowca");
            var biuro = new IdentityRole("Biuro");

            context.Roles.AddOrUpdate(x => x.Name, dziekan, admin, wykladowca, biuro);

            if (!context.Users.Any(u => u.UserName == "admin@gmail.com"))
            {
                var administrator = new Uzytkownik() { Id = Guid.NewGuid().ToString(), UserName = "admin@gmail.com", Imie = "Adam", Nazwisko = "Nowak", Email = "admin@gmail.com", PasswordHash = passwordHasher.HashPassword("123"), SecurityStamp = Guid.NewGuid().ToString() };

                var adminRole = new IdentityUserRole();
                adminRole.RoleId = admin.Id;
                adminRole.UserId = administrator.Id;
                administrator.Roles.Add(adminRole);

                context.Users.Add(administrator);
            }

            if (!context.Users.Any(u => u.UserName == "wykladowca@gmail.com"))
            {
                var wykladowca1 = new Uzytkownik() { Id = Guid.NewGuid().ToString(), UserName = "wykladowca@gmail.com", Imie = "Jan", Nazwisko = "Kowalski", Email = "wykladowca@gmail.com", PasswordHash = passwordHasher.HashPassword("123"), SecurityStamp = Guid.NewGuid().ToString() };

                var wykladowcaRole1 = new IdentityUserRole();
                wykladowcaRole1.RoleId = wykladowca.Id;
                wykladowcaRole1.UserId = wykladowca1.Id;
                wykladowca1.Roles.Add(wykladowcaRole1);

                context.Users.Add(wykladowca1);
            }

            if (!context.Users.Any(u => u.UserName == "wykladowca2@gmail.com"))
            {
                var wykladowca2 = new Uzytkownik() { Id = Guid.NewGuid().ToString(), UserName = "wykladowca2@gmail.com", Imie = "Bartosz", Nazwisko = "D¹browski", Email = "wykladowca2@gmail.com", PasswordHash = passwordHasher.HashPassword("123"), SecurityStamp = Guid.NewGuid().ToString() };

                wykladowca2.Tytuly.Add(dr);
                wykladowca2.Tytuly.Add(inz);

                var wykladowcaRole2 = new IdentityUserRole();
                wykladowcaRole2.RoleId = wykladowca.Id;
                wykladowcaRole2.UserId = wykladowca2.Id;
                wykladowca2.Roles.Add(wykladowcaRole2);

                context.Users.Add(wykladowca2);
            }


            var wiedzaEfekt = new RodzajEfektu() { Id = 1, Nazwa = "Wiedza" };
            var umiejetnosciEfekt = new RodzajEfektu() { Id = 2, Nazwa = "Umiejêtnoœci" };
            var kompetencjeEfekt = new RodzajEfektu() { Id = 3, Nazwa = "Kompetencje" };

            context.RodzajeEfektow.AddOrUpdate(x => x.Id,
                wiedzaEfekt,
                umiejetnosciEfekt,
                kompetencjeEfekt
                );

            var wydzialAdmwPlocku = new Wydzial() { Id = 1, Nazwa = "Wydzia³ Administracji w P³ocku" };
            var wydzialBezpwPlocku = new Wydzial() { Id = 2, Nazwa = "Wydzia³ Bezpieczeñstwa Narodowego w P³ocku" };
            var wydzialInfwPlocku = new Wydzial() { Id = 3, Nazwa = "Wydzia³ Informatyki w P³ocku" };
            var wydzialNaukwPlocku = new Wydzial() { Id = 4, Nazwa = "Wydzia³ Nauk Spo³ecznych w P³ocku" };
            var wydzialPedwPlocku = new Wydzial() { Id = 5, Nazwa = "Wydzia³ Pedagogiczny w P³ocku" };
            var wydzialWfwPlocku = new Wydzial() { Id = 6, Nazwa = "Wydzia³ Wychowania Fizycznego w P³ocku" };
            var wydzialZarzawPlocku = new Wydzial() { Id = 7, Nazwa = "Wydzia³ Zarz¹dzania w P³ocku" };

            var Istlic = new Poziom() { Id = 1, Nazwa = "I st. licencjacki" };
            var IIst = new Poziom() { Id = 3, Nazwa = "II stopnia" };
            var Istinz = new Poziom() { Id = 2, Nazwa = "I st. in¿ynierski" };
            var pomostowy = new Poziom() { Id = 4, Nazwa = "I st. lic. pomostowy" };
            context.Poziomy.AddOrUpdate(x => x.Id,
                Istlic,
                Istinz,
                IIst,
                pomostowy
                );

            context.Wydzialy.AddOrUpdate(x => x.Id,
                wydzialAdmwPlocku,
                wydzialBezpwPlocku,
                wydzialInfwPlocku,
                //wydzialNaukwPlocku,
                wydzialPedwPlocku,
                wydzialWfwPlocku,
                wydzialZarzawPlocku
                //new Wydzial() { Id = 8, Nazwa = "Wydzia³ Administracji w Wyszkowie" },
                //new Wydzial() { Id = 9, Nazwa = "Wydzia³ Pedagogiczny w Wyszkowie" },
                //new Wydzial() { Id = 10, Nazwa = "Wydzia³ Pielêgniarstwa w Wyszkowie" },
                //new Wydzial() { Id = 11, Nazwa = "Wydzia³ Zarz¹dzania w Wyszkowie" },
                //new Wydzial() { Id = 12, Nazwa = "Wydzia³ Administracji w I³awie" },
                //new Wydzial() { Id = 13, Nazwa = "Wydzia³ Pedagogiczny w I³awie" }
                );

            context.Efekty.AddOrUpdate(x => new { x.PoziomId, x.WydzialId, x.Skrot, x.RodzajEfektuId },
                //Wydzia³ Administracji w P³ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W01", Opis = "ma podstawow¹ wiedzê o istocie nauk o administracji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W02", Opis = "ma podstawow¹ wiedzê o miejscu nauki o administracji w dziedzinie nauk prawnych oraz obszarze nauk spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W03", Opis = "ma uporz¹dkowan¹ wiedzê o ró¿nych aspektach ¿ycia spo³ecznego a w szczególnoœci funkcjonowania administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W04", Opis = "zna podstawowe elementy struktur administracji publicznej oraz sfery ¿ycia publicznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W05", Opis = "ma podstawow¹ wiedzê z zakresu organizacji i funkcjonowania administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W06", Opis = "ma podstawow¹ wiedz¹ o porz¹dku prawnym jako systemie oraz wzajemnych relacjach zachodz¹cych w tym systemie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W07", Opis = "zna rodzaje relacji i stosunków zachodz¹cych w administracji, w szczególnoœci stosunków prawnych, organizacyjnych, ekonomicznych oraz spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W08", Opis = "ma podstawow¹ wiedzê o wzajemnych relacjach pomiêdzy ró¿nymi podmiotami wykonuj¹cymi zadania z zakresu administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W09", Opis = "ma podstawow¹ wiedzê o prawach i obowi¹zkach obywatelskich wynikaj¹cych z przepisów Konstytucji, przepisów prawa miêdzynarodowego publicznego oraz przepisów prawa administracyjnego materialnego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W10", Opis = "ma wiedzê o miejscu i roli jednostki oraz grupy w administracji oraz strukturach pañstwa, a tak¿e instrumentach ich oddzia³ywania na instytucje publiczne", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W11", Opis = "posiada podstawow¹ wiedzê w zakresie metodologii nauk prawnych, w szczególnoœci nauk o administracji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W12", Opis = "posiada podstawow¹ wiedzê z zakresu metodologii innych wybranych dyscyplin zaliczanych do obszaru nauk spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W13", Opis = "ma wiedzê w zakresie prawno-ustrojowych podstaw konstytuuj¹cych funkcjonowanie pañstwa, jego organów i instytucji ze szczególnym uwzglêdnieniem administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W14", Opis = "ma wiedzê o zasadach i regu³ach wewnêtrznej organizacji administracji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W15", Opis = "posiada wiedzê o procesach zmian organizacji oraz zasad funkcjonowania struktur pañstwowych i administracji publicznej. Zna przyczyny, przebieg a tak¿e skutki realizacji tych procesów", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W16", Opis = "zna genezê, przebieg i skutki zmian ustroju pañstw, organizacji i innych wybranych struktur politycznych w ujêciu historycznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W17", Opis = "posiada wiedzê o podstawowych nurtach myœli polityczno-prawnej i spo³eczno-ekonomicznej, ze szczególnym uwzglêdnieniem myœli administracyjnej, a tak¿e ich ewolucji oraz kontekstu historycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W18", Opis = "posiada podstawow¹ wiedzê z zakresu ochrony w³asnoœci przemys³owej i prawa autorskiego oraz rolê administracji w tym zakresie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W19", Opis = "zna podstawowe zasady podejmowania i prowadzenia dzia³alnoœci gospodarczej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_W20", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U01", Opis = "potrafi w³aœciwie interpretowaæ zachodz¹ce zjawiska prawne, spo³eczne, ekonomiczne, polityczne i organizacyjne zwi¹zane z administracj¹ publiczn¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U02", Opis = "umie wykorzystaæ posiadan¹ wiedzê teoretyczn¹ do analizy i rozwi¹zania indywidualnego przypadku lub zjawiska wystêpuj¹cego w administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U03", Opis = "umie dokonaæ oceny prawid³owoœci postêpowania organu administracji publicznej w konkretnej sprawie stosuj¹c kryteria ogólnie pojête", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U04", Opis = "potrafi w³aœciwie analizowaæ i interpretowaæ przyczyny, przebieg oraz skutki podstawowych procesów zwi¹zanych z administracj¹ publiczn¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U05", Opis = "potrafi samodzielnie dokonaæ prostej analizy tekstów prawnych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U06", Opis = "potrafi podczas praktycznego rozwi¹zywania problemów w administracji wykorzystaæ podstawowe metody i narzêdzia w³aœciwe dla nauk prawnych oraz wybranych nauk spo³ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U07", Opis = "umie stosowaæ normy prawne w celu rozwi¹zania konkretnego zagadnienia z obszaru administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U08", Opis = "umie stosowaæ normy etyki urzêdniczej oraz zasady zawodowe urzêdnika w celu rozwi¹zania konkretnego zagadnienia z obszaru administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U09", Opis = "potrafi wykorzystaæ podstawow¹ wiedzê teoretyczn¹ oraz praktyczn¹ nabyt¹ w toku studenckich praktyk zawodowych do dzia³ania na stanowisku administracyjnym w administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U10", Opis = "posiada umiejêtnoœæ krytycznej analizy oraz wyboru optymalnego rozwi¹zania dla konkretnego problemu zwi¹zanego z administracj¹ publiczn¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U11", Opis = "posiada zdolnoœæ skutecznej implementacji zaproponowanych rozwi¹zañ w praktyce funkcjonowania administracji", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U12", Opis = "rozumie i potrafi analizowaæ zjawiska spo³eczne zwi¹zane z administracj¹ i szeroko rozumianym ¿yciem publicznym", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U13", Opis = "potrafi przygotowaæ siê i wypowiedzieæ pisemnie w jêzyku polskim w zakresie zagadnieñ zwi¹zanych z administracj¹, w szczególnoœci stosowaæ formalny jêzyk prawny i prawniczy, z wykorzystaniem konstrukcji teoretycznych oraz stosownych Ÿróde³", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U14", Opis = "potrafi przygotowaæ siê i wypowiedzieæ pisemnie w wybranym jêzyku obcym w zakresie zagadnieñ zwi¹zanych z administracj¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U15", Opis = "potrafi przygotowaæ siê i wypowiedzieæ ustnie w jêzyku polskim w zakresie zagadnieñ zwi¹zanych z administracj¹, w szczególnoœci stosowaæ jêzyk prawny i prawniczy, z wykorzystaniem konstrukcji teoretycznych oraz stosownych Ÿróde³", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U16", Opis = "potrafi przygotowaæ siê i wypowiedzieæ ustnie w wybranym jêzyku obcym w zakresie zagadnieñ zwi¹zanych z administracj¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U17", Opis = "ma umiejêtnoœci jêzykowe w zakresie ogólnym oraz administracji zgodne z wymaganiami okreœlonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta³cenia Jêzykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_U18", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K01", Opis = "rozumie potrzebê uczenia siê przez ca³e ¿ycie, dostrzega korzyœci p³yn¹ce z podwy¿szania kwalifikacji", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K02", Opis = "potrafi wspó³dzia³aæ w pracy zespo³owej, przyjmuj¹c ró¿ne role w grupie", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K03", Opis = "potrafi kierowaæ niewielkim zespo³em pracowników", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K04", Opis = "potrafi wyznaczaæ priorytety dzia³ania organów administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K05", Opis = "prawid³owo identyfikuje i rozstrzyga problemy zwi¹zane z efektywnym wykonywaniem zadañ pracownika administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K06", Opis = "potrafi aktywnie uczestniczyæ w przygotowaniu projektów zwi¹zanych z zakresem zadañ administracji publicznej wraz z ich podstaw¹ formalno-prawn¹", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K07", Opis = "rozumie potrzebê pozyskiwania spo³ecznej akceptacji dla dzia³añ w³adz publicznych, w tym równie¿ organów administracyjnych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K08", Opis = "posiada zdolnoœæ samodzielnego uzupe³niania i doskonalenia zdobytej wiedzy i umiejêtnoœci z obszaru nauk prawnych oraz wybranych nauk spo³ecznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K09", Opis = "potrafi podejmowaæ ró¿norodne dzia³ania na rzecz rozwoju spo³ecznoœci lokalnych wykorzystuj¹c zdobyt¹ wiedzê z zakresu nauk o administracji i wybranych nauk z obszaru nauk spo³ecznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_K10", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W01", Opis = "zna i rozumie w pog³êbionym stopniu - wybrane fakty, obiekty i zjawiska z zakresu administracji publicznej, dotycz¹ce ich metody i teorie wyjaœniaj¹ce zale¿noœci miêdzy nimi, stanowi¹ce podstawow¹ wiedzê z zakresu dyscyplin naukowych tworz¹cych podstawy teoretyczne dla nauk o administracji oraz wybrane zagadnienia z zakresu dziedziny nauk prawnych i obszaru nauk spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W02", Opis = "zna i rozumie g³ówne trendy w tym ogóln¹ metodologiê badañ w zakresie dyscyplin naukowych przypisanych do kierunku administracja", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W03", Opis = "zna i rozumie w pog³êbionym stopniu teorie naukowe w³aœciwe dla kierunku studiów administracja oraz kierunki ich rozwoju, a tak¿e zaawansowan¹ metodologiê badañ", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W04", Opis = "zna i rozumie w pog³êbionym stopniu charakter, miejsce i znaczenie nauk spo³ecznych w systemie nauk oraz ich relacje do innych nauk", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W05", Opis = "zna i rozumie w pog³êbionym stopniu cechy cz³owieka jako twórcy kultury i podmiotu konstytuuj¹cego struktury spo³eczne oraz zasady ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W02", Opis = "zna i rozumie fundamentalne dylematy wspó³czesnej cywilizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W06", Opis = "zna i rozumie ekonomiczne, prawne i inne uwarunkowania ró¿nych rodzajów dzia³añ zwi¹zanych z nadan¹ kwalifikacj¹, w tym zasady ochrony w³asnoœci przemys³owej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W07", Opis = "zna i rozumie zasady zarz¹dzania zasobami w³asnoœci intelektualnej oraz formy rozwoju indywidualnej przedsiêbiorczoœci", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_W08", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywaæ posiadan¹ wiedzê – formu³owaæ i rozwi¹zywaæ z³o¿one i nietypowe problemy i innowacyjnie wykonywaæ zadania w nieprzewidywalnych warunkach przez: - w³aœciwy dobór Ÿróde³ oraz informacji z nich pochodz¹cych, - dokonywanie oceny, krytycznej analizy, syntezy oraz twórczej interpretacji i prezentacji tych informacji; - dobór oraz stosowanie w³aœciwych metod i narzêdzi, w tym zaawansowanych technik informacyjno-komunikacyjnych (ICT)", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U02", Opis = "potrafi identyfikowaæ, interpretowaæ i wyjaœniaæ z³o¿one zjawiska i procesy spo³eczne oraz relacje miêdzy nimi z wykorzystaniem wiedzy z dyscyplin naukowych przypisanych do kierunku studiów 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U03", Opis = "potrafi prognozowaæ i modelowaæ z³o¿one procesy spo³eczne oraz ich praktyczne skutki z wykorzystaniem zaawansowanych metod i narzêdzi dyscyplin naukowych w³aœciwych dla administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U04", Opis = "potrafi prawid³owo pos³ugiwaæ siê aktami prawnymi z wykorzystaniem wiedzy z zakresu obowi¹zuj¹cych rozwi¹zañ prawnych oraz orzecznictwa s¹dów administracyjnych w³aœciwych dla kierunku 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U05", Opis = "potrafi prognozowaæ praktyczne skutki procesów i zjawisk w obszarze funkcjonowania administracji publicznej z wykorzystaniem standardowych metod i narzêdzi dyscyplin naukowych w³aœciwych dla kierunku 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U06", Opis = "potrafi braæ udzia³ w dyskursie dotycz¹cym problematyki administracji publicznej - przedstawiaæ i oceniaæ odmienne opinie i stanowiska oraz dyskutowaæ o nich", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U07", Opis = "potrafi pos³ugiwaæ siê jêzykiem obcym na poziomie B2+ Europejskiego Systemu Opisu Kszta³cenia Jêzykowego w zakresie specjalistycznej terminologii w³aœciwej dla kierunku 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U08", Opis = "potrafi planowaæ i organizowaæ prac¹ zespo³u w obszarze funkcjonowania administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U09", Opis = "potrafi samodzielnie planowaæ i realizowaæ w³asne uczenie siê przez ca³e ¿ycie", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_U10", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K01", Opis = "jest gotów do krytycznej oceny odbieranych treœci, ze szczególnym uwzglêdnieniem wiedzy dotycz¹cej kierunku 'administracja'", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K02", Opis = "jest gotów do uznawania znaczenia wybranej wiedzy z obszaru nauk spo³ecznych podczas rozwi¹zywania problemów poznawczych i praktycznych pojawiaj¹cych siê w dzia³alnoœci administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K03", Opis = "jest gotów do wype³niania zobowi¹zañ spo³ecznych oraz wspó³organizowania dzia³alnoœci urzêdniczej na rzecz otoczenia spo³ecznego administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K04", Opis = "jest gotów do inicjowania dzia³añ w³asnych i urzêdników administracji publicznej na rzecz interesu publicznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K05", Opis = "jest gotów do myœlenia i dzia³ania w sposób przedsiêbiorczy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K06", Opis = "jest gotów do kultywowania i upowszechniania wzorów w³aœciwego postêpowania w administracji publicznej oraz œrodowisku spo³ecznym, w szczególnoœci: rozwijania dorobku zawodu, podtrzymywania etosu wykonywanego zawodu, przestrzegania i rozwijania zasad etyki zawodowej oraz dzia³ania na rzecz przestrzegania tych zasad", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K07", Opis = "jest gotów do samodzielnego podejmowania decyzji, krytycznej oceny dzia³añ w³asnych, dzia³añ zespo³ów, którymi kieruje, oraz których jest cz³onkiem, a tak¿e przyjmowania odpowiedzialnoœci za skutki tych dzia³añ", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K08", Opis = "jest gotów do przewodzenia grupie i ponoszenia odpowiedzialnoœci za ni¹", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_K09", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzia³ Bezpieczeñstwa narodowego w P³ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W01", Opis = "Posiada podstawow¹ wiedzê o naukach o bezpieczeñstwie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W02", Opis = "Posiada ogóln¹ wiedzê o dziedzinach nauk wspomagaj¹cych nauki o bezpieczeñstwie takich jak: nauki spo³eczne, ekonomiczne i prawne oraz zachodz¹cych miêdzy nimi relacjami i wspó³zale¿noœciami", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W03", Opis = "Zna struktury systemu bezpieczeñstwa pañstwa, uwarunkowania polityczno-prawne oraz zale¿noœci ekonomiczne w szczególnoœci pomiêdzy podstawowymi elementami systemu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W04", Opis = "Ma podstawow¹ wiedzê o relacjach miêdzy strukturami i instytucjami odpowiedzialnymi za bezpieczeñstwo narodowe na wszystkich poziomach jego organizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W05", Opis = "Ma elementarn¹ wiedzê o miejscu nauk o bezpieczeñstwie i wiêziach z innymi dyscyplinami naukowymi w³aœciwych dla studiowania relacji, prawid³owoœci i powi¹zañ miêdzy nimi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W06", Opis = "Posiada podstawow¹ wiedzê o koncepcjach, zasadach kszta³towania struktur spo³ecznych na rzecz szeroko pojêtego bezpieczeñstwa, a tak¿e dzia³ania w tych strukturach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W07", Opis = "Zna metody i techniki pozyskiwania informacji pomiêdzy podsystemami wykonawczymi, a podsystemem kierowania i zarz¹dzania bezpieczeñstwem", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W08", Opis = "Potrafi scharakteryzowaæ i opisaæ struktury zajmuj¹ce siê bezpieczeñstwem w aspektach zewnêtrznych i wewnêtrznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W09", Opis = "Posiada uporz¹dkowan¹ wiedzê o wybranych (dominuj¹cych) podmiotach odpowiedzialnych za funkcjonowanie lokalnych systemów bezpieczeñstwa z uwzglêdnieniem organizacji spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W10", Opis = "Zna i rozumie regu³y proceduralne normy organizacyjne instytucji spo³ecznych odpowiedzialnych za bezpieczeñstwo w tym sposoby dzia³ania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W11", Opis = "Ma pog³êbion¹ wiedzê o procesach zmian wybranych struktur oraz instytucji odpowiedzialnych za zarz¹dzanie bezpieczeñstwem", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W12", Opis = "Zna podstawowe elementy sk³adowe struktur zarz¹dzaj¹cych bezpieczeñstwem, a tak¿e konsekwencje wynikaj¹ce ze zmian przyczynowo-skutkowych i prawid³owoœciach implikuj¹cych te zmiany", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W13", Opis = "Ma ugruntowan¹ wiedzê na temat podstawowych struktur instytucji odpowiedzialnych za obronnoœæ w wymiarze narodowym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W14", Opis = "Zna rys historyczny z uwzglêdnieniem edukacji strukturalnej i wp³ywu wiêzi spo³eczno-prawnych, praktycznych zastosowañ tych zmian wp³ywaj¹cych na bezpieczeñstwo obywateli", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W15", Opis = "Posiada elementarn¹ wiedzê z zakresu ochrony w³asnoœci przemys³owej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W16", Opis = "Zna procedury zarz¹dzania bezpieczeñstwem przemys³owym oraz logistyk¹ w sytuacjach kryzysowych z uwzglêdnieniem czynników formalno-prawnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W17", Opis = "Zna ogólne zasady tworzenia i rozwoju form indywidualnej przedsiêbiorczoœci, wykorzystuj¹cej wiedzê z zakresu dziedzin nauk spo³ecznych, ekonomicznych i prawnych oraz dyscyplin naukowych w³aœciwych dla studiowanego kierunku studiów tj: nauk o bezpieczeñstwie, obronnoœci, polityce, psychologii, socjologii, ekonomii, nauk o zarz¹dzaniu, administracji i prawie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "U_W18", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U01", Opis = "Potrafi prawid³owo interpretowaæ, analizowaæ, wyjaœniaæ zjawiska i zale¿noœci wystêpuj¹ce pomiêdzy dziedzinami specyficznymi dla studiowanego kierunku studiów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U02", Opis = "Umie stosowaæ w praktyce wiedzê teoretyczn¹ do szczegó³owego opisywania przyczynowo-skutkowego procesów i procedur bezpieczeñstwa narodowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U03", Opis = "Potrafi formu³owaæ i obiektywnie uzasadniaæ w³asne opinie w oparciu o posiadane dane i wiedzê", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U04", Opis = "Potrafi dokonywaæ w³aœciwej analizy procedur bezpieczeñstwa specyficznych dla dziedzin nauki i dyscyplin naukowych w³aœciwych dla studiowanego kierunku studiów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U05", Opis = "Zna i potrafi wykorzystaæ prognozy konkretnych zjawisk implikuj¹cych stan bezpieczeñstwa", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U06", Opis = "Potrafi wykorzystaæ w praktyce standardowe metody, narzêdzia i zasady wykorzystywane we w³aœciwych dyscyplinach nauki wspó³graj¹cych ze studiowanym kierunkiem studiów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U07", Opis = "Prawid³owo pos³uguje siê wybranymi systemami normatywnymi i umie je wykorzystaæ w praktyce", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U08", Opis = "Zna podstawowe funkcje i regu³y kszta³tuj¹ce istotê bezpieczeñstwa wynikaj¹ce z konkretnego zadania praktycznego z zakresu zgrywania dziedzin nauki i dyscyplin naukowych w³aœciwych dla studiowanego kierunku studiów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U09", Opis = "Posiada umiejêtnoœæ zgrywania wiedzy teoretycznej z umiejêtnoœciami praktycznymi nabytymi podczas praktyk zawodowych w celu realizacji z zadañ z zakresu bezpieczeñstwa narodowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U10", Opis = "Trafnie analizuje zaistnia³e problemy, potrafi proponowaæ konkretne rozwi¹zania i rozstrzygniêcia sytuacji spornych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U11", Opis = "Posiada zdolnoœæ wdra¿ania proponowanych rozwi¹zañ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U12", Opis = "Posiada umiejêtnoœæ rozumienia, diagnozowania i analizowania, a tak¿e oceniania zjawisk w wybranych procedurach bezpieczeñstwa z uwypukleniem wskazanych dyscyplin naukowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U13", Opis = "Posiada umiejêtnoœæ opracowywania charakterystycznych prac pisemnych w jêzyku polskim i jêzyku obcym specyficznych dla dziedzin i dyscyplin nauki z obszaru nauk spo³ecznych spójnych ze studiowanym kierunkiem studiów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U14", Opis = "Ma zdolnoœæ w wyszukiwaniu pojêæ i definicji w ró¿nych Ÿród³ach oraz bieg³oœæ w wykorzystywaniu ich do celów praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U15", Opis = "Posiada umiejêtnoœæ wykorzystania posiadanej wiedzy i jej ekspozycji w wyst¹pieniach ustnych w jêzyku polskim i jêzyku obcym w dziedzinach i dyscyplinach nauki z obszaru nauk spo³ecznych spójnych ze studiowanym kierunkiem studiów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U16", Opis = "Ma zdolnoœæ oraz bieg³oœæ w umiejêtnym wykorzystywaniu pojêæ wraz z szczegó³ow¹ analiz¹ do celów praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U17", Opis = "Ma umiejêtnoœci jêzykowe w zakresie dziedzin nauki i dyscyplin naukowych w³aœciwych dla zakresu tematyczno-problemowego nauk o bezpieczeñstwie zgodne z wymaganiami okreœlonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta³cenia Jêzykowego. Posiada odpowiedni¹ bieg³oœæ w pos³ugiwaniu siê jêzykiem obcym niezbêdn¹ do wykonywania aktualnych zadañ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "U_U18", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K01", Opis = "Rozumie potrzebê uczenia siê przez ca³e ¿ycie", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K02", Opis = "Potrafi wspó³pracowaæ i wspó³dzia³aæ w grupie rozumiej¹c znaczenie funkcji i relacji prze³o¿ony i podw³adny", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K03", Opis = "Dostrzega znaczenie zmiennoœci funkcji w grupie, umie przyjmowaæ ró¿ne role w jej strukturach", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K04", Opis = "Umie prawid³owo wyznaczaæ g³ówne priorytety s³u¿¹ce realizacji zadañ grupowych i indywidualnych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K05", Opis = "Prawid³owo rozpoznaje wszelkie sk³adowe charakterystyczne dla wybranej specjalnoœci studiów", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K06", Opis = "Potrafi rozstrzygaæ i uzasadniaæ wszelkie w¹tpliwoœci wynikaj¹ce ze specyfiki zawodu i danego obszaru dzia³alnoœci", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K07", Opis = "Rozumie istotê i znaczenie projektów spo³ecznych w zakresie polepszania funkcjonuj¹cego systemu bezpieczeñstwa", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K08", Opis = "Potrafi przewidywaæ wszelkie uwarunkowania: polityczne, gospodarcze, obywatelskie wszelkich inicjatywach spo³ecznych w aspekcie bezpieczeñstwa narodowego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K09", Opis = "Aktywnie uczestniczy w powstawaniu projektów spo³ecznych uwydatniaj¹c w nich elementy prawne, ekonomiczne i polityczne", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K10", Opis = "Potrafi samodzielnie uzupe³niaæ posiadan¹ wiedzê", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K11", Opis = "Rozumie znaczenie samoewaluacji i ci¹g³ego doskonalenia posiadanych umiejêtnoœci", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K12", Opis = "Potrafi gromadziæ i przetwarzaæ wszelkie informacje wykazuj¹c siê przedsiêbiorczoœci¹ w dzia³aniu", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "U_K13", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzia³ Informatyki w P³ocku
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W01", Opis = "ma wiedzê z zakresu matematyki i fizyki niezbêdn¹ do formu³owania i rozwi¹zywania typowych, prostych zadañ z zakresu informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W02", Opis = "ma podstawow¹ wiedzê w zakresie kierunków studiów powi¹zanych z informatyk¹", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W03", Opis = "posiada wiedzê ogóln¹ z zakresu kluczowych zagadnieñ informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W04", Opis = "ma szczegó³ow¹ wiedzê zwi¹zan¹ z wybranymi zagadnieniami z informatyki: programowania, sieci komputerowych, teleinformatyki, baz danych, grafiki komputerowej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W05", Opis = "ma podstawow¹ wiedzê o cyklu ¿ycia systemów informatycznych i sieci teleinformatycznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W06", Opis = "zna podstawowe metody, techniki i narzêdzia stosowane przy rozwi¹zywaniu prostych zadañ in¿ynierskich z zakresu informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W07", Opis = "ma podstawow¹ wiedzê w zakresie standardów i norm technicznych wystêpuj¹cych w informatyce", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W08", Opis = "ma podstawow¹ wiedzê niezbêdn¹ do rozumienia spo³ecznych, ekonomicznych i prawnych uwarunkowañ dzia³alnoœci in¿yniera informatyka", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W09", Opis = "ma podstawow¹ wiedzê dotycz¹c¹ zarz¹dzania, w tym zarz¹dzania jakoœci¹, i prowadzenia dzia³alnoœci gospodarczej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W10", Opis = "zna i rozumie podstawowe pojêcia i zasady z zakresu ochrony w³asnoœci intelektualnej i prawa autorskiego w odniesieniu do produktów rynku informatycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W11", Opis = "zna ogólne zasady tworzenia i rozwoju form indywidualnej przedsiêbiorczoœci w dziedzinie informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "U_W12", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U01", Opis = "potrafi pozyskiwaæ informacje z literatury, baz danych oraz innych w³aœciwie dobranych Ÿróde³, tak¿e w jêzyku angielskim w zakresie informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U02", Opis = "potrafi integrowaæ uzyskane informacje, dokonywaæ ich interpretacji, a tak¿e wyci¹gaæ wnioski oraz formu³owaæ i uzasadniaæ opinie w dziedzinie informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U03", Opis = "potrafi porozumiewaæ siê przy u¿yciu ró¿nych technik w œrodowisku zawodowym informatyków oraz w innych œrodowiskach, wykorzystuj¹cych us³ugi informatyczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U04", Opis = "potrafi przygotowaæ w jêzyku polskim i jêzyku angielskim, dobrze udokumentowane opracowanie problemów z zakresu informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U05", Opis = "potrafi przygotowaæ i przedstawiæ w jêzyku polskim i jêzyku angielskim prezentacjê ustn¹, dotycz¹c¹ szczegó³owych zagadnieñ z zakresu informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U06", Opis = "ma umiejêtnoœæ samokszta³cenia siê", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U07", Opis = "ma umiejêtnoœci pos³ugiwania siê jêzykiem angielskim w zakresie informatyki, zgodne z wymaganiami okreœlonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta³cenia Jêzykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U08", Opis = "potrafi pos³ugiwaæ siê technikami informacyjno-komunikacyjnymi w³aœciwymi do realizacji zadañ typowych dla dzia³alnoœci in¿ynierskiej w dziedzinie informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U09", Opis = "potrafi planowaæ i przeprowadzaæ eksperymenty w dziedzinie informatyki, interpretowaæ uzyskane wyniki i wyci¹gaæ wnioski", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U10", Opis = "potrafi wykorzystaæ do formu³owania i rozwi¹zywania zadañ in¿ynierskich metody analityczne, symulacyjne oraz eksperymentalne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U11", Opis = "potrafi — przy formu³owaniu i rozwi¹zywaniu informatycznych zadañ in¿ynierskich - dostrzegaæ ich aspekty systemowe i pozatechniczne, w tym spo³eczne i kulturowe", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U12", Opis = "ma umiejêtnoœci niezbêdne do pracy w profesjonalnych œrodowiskach informatycznych oraz zna i stosuje zasady bezpieczeñstwa systemów komputerowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U13", Opis = "potrafi dokonaæ wstêpnej analizy ekonomicznej podejmowanych dzia³añ in¿ynierskich w obszarze praktycznych zastosowañ informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U14", Opis = "potrafi dokonaæ krytycznej analizy sposobu funkcjonowania systemów informatycznych i teleinformatycznych oraz oceniæ istniej¹ce rozwi¹zania techniczne, w szczególnoœci urz¹dzenia sieciowe i komputerowe, systemy informatyczne, procesy oraz us³ugi z nimi zwi¹zane", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U15", Opis = "potrafi dokonaæ identyfikacji i sformu³owaæ specyfikacjê prostych informatycznych zadañ in¿ynierskich o charakterze praktycznym", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U16", Opis = "potrafi oceniæ przydatnoœæ rutynowych metod i narzêdzi informatycznych s³u¿¹cych do rozwi¹zania prostego zadania in¿ynierskiego o charakterze praktycznym oraz wybraæ i zastosowaæ w³aœciw¹ metodê (procedurê) i narzêdzia informatyczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U17", Opis = "potrafi zaprojektowaæ oraz zrealizowaæ prosty system informatyczny lub strukturê sieci teleinformatycznej, u¿ywaj¹c w³aœciwych metod, technik i narzêdzi", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U18", Opis = "ma doœwiadczenie zwi¹zane z utrzymaniem systemów informatycznych lub sieci teleinformatycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U19", Opis = "ma doœwiadczenie zwi¹zane z rozwi¹zywaniem praktycznych zadañ in¿ynierskich, zdobyte w œrodowisku zajmuj¹cym siê zawodowo dzia³alnoœci¹ in¿yniersk¹ w obszarze informatyki lub teleinformatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U20", Opis = "ma umiejêtnoœæ korzystania i doœwiadczenie w korzystaniu z norm i standardów zwi¹zanych z informatyka, a w szczególnoœci metod: in¿ynierii programowania, projektowania sieci teleinformatycznych oraz bezpieczeñstwa systemów komputerowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "U_U21", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K01", Opis = "rozumie potrzebê uczenia siê przez ca³e ¿ycie poprzez pog³êbianie wiedzy i umiejêtnoœci w dziedzinie informatyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K02", Opis = "ma œwiadomoœæ wa¿noœci i rozumie spo³eczne i kulturowe aspekty i skutki dzia³alnoœci in¿ynierskiej w dziedzinie zastosowañ informatyki; ma œwiadomoœæ odpowiedzialnoœci za podejmowane decyzje w dziedzinie zastosowañ narzêdzi i metod informatycznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K03", Opis = "potrafi wspó³dzia³aæ i pracowaæ w grupie, przyjmuj¹c w niej ró¿ne role w zakresie projektowania, budowy i wdro¿eñ systemów informatycznych i teleinformatycznych; potrafi przyjmowaæ ró¿ne role w zespole: koordynatora, analityka, wykonawcy, itp..", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K04", Opis = "potrafi odpowiednio okreœliæ priorytety s³u¿¹ce realizacji okreœlonego przez siebie lub innych zadania informatycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K05", Opis = "prawid³owo identyfikuje i rozstrzyga dylematy zwi¹zane z wykonywaniem zawodu informatyka", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K06", Opis = "potrafi myœleæ i dzia³aæ w sposób przedsiêbiorczy w dziedzinie zastosowañ informatyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K07", Opis = "ma œwiadomoœæ roli spo³ecznej informatyka, w szczególnoœci rozumie potrzebê formu³owania i przekazywania spo³eczeñstwu poprzez œrodki masowego przekazu, w sposób komunikatywny informacji i opinii dotycz¹cych osi¹gniêæ w dziedzinie informatyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "U_K08", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzia³ Pedagogiki w P³ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W01", Opis = "ma uporz¹dkowan¹ wiedzê o ró¿nych œrodowiskach wychowawczych, ich specyfice i procesach w nich zachodz¹cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W02", Opis = "w zaawansowanym stopniu zna teorie dotycz¹ce wychowania, uczenia siê i nauczania, rozumie ró¿norodne uwarunkowania tych procesów", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W03", Opis = "posiada w znacznym stopniu wiedzê o metodyce wykonywania typowych zadañ, normach, procedurach stosowanych w ró¿nych obszarach dzia³alnoœci pedagogicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W04", Opis = "zna terminologiê u¿ywan¹ w pedagogice i rozumie jej Ÿród³a oraz zastosowania w obrêbie pokrewnych dyscyplin naukowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W05", Opis = "ma ogóln¹ wiedzê o projektowaniu i prowadzeniu badañ w pedagogice, a w szczególnoœci o problemach badawczych, metodach, technikach i narzêdziach badawczych; zna podstawowe tradycje paradygmatyczne badañ spo³ecznych, z których wywodz¹ siê poszczególne metody", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W06", Opis = "ma wiedzê o miejscu pedagogiki w systemie nauk oraz o jej przedmiotowych i metodologicznych powi¹zaniach z innymi dyscyplinami naukowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W07", Opis = "zna koncepcje cz³owieka: filozoficzne, psychologiczne i spo³eczne stanowi¹ce teoretyczne podstawy dzia³alnoœci pedagogicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W08", Opis = "ma wiedzê na temat rozwoju cz³owieka w cyklu ¿ycia zarówno w aspekcie biologicznym, jak i psychologicznym oraz spo³ecznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W09", Opis = "posiada wiedzê o uczestnikach dzia³alnoœci edukacyjnej, wychowawczej, opiekuñczej, kulturalnej i pomocowej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W10", Opis = "ma uporz¹dkowan¹ wiedzê na temat wychowania i kszta³cenia, jego filozoficznych, spo³eczno-kulturowych, historycznych, biologicznych, psychologicznych i medycznych podstaw", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W11", Opis = "posiada wiedzê o rodzajach wiêzi spo³ecznych i o rz¹dz¹cych nimi prawid³owoœciach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W12", Opis = "ma wiedzê o bezpieczeñstwie i higienie pracy w instytucjach edukacyjnych, wychowawczych, opiekuñczych, kulturalnych i pomocowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W13", Opis = "ma wiedzê dotycz¹c¹ procesów komunikowania interpersonalnego i spo³ecznego, ich prawid³owoœci i zak³óceñ", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W14", Opis = "ma rozbudowan¹ wiedzê na temat projektowania œcie¿ki w³asnego rozwoju", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W15", Opis = "ma uporz¹dkowan¹ wiedzê na temat zasad i norm etycznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W16", Opis = "zna najwa¿niejsze tradycyjne i wspó³czesne nurty i systemy pedagogiczne, rozumie ich historyczne i kulturowe uwarunkowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W17", Opis = "ma wiedzê o strukturze i funkcjach systemu edukacji; celach, podstawach prawnych, organizacji i funkcjonowaniu ró¿nych instytucji edukacyjnych, wychowawczych, opiekuñczych, terapeutycznych, kulturalnych i pomocowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_W18", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U01", Opis = "potrafi innowacyjnie planowaæ i realizowaæ zadania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U02", Opis = "potrafi oceniæ przydatnoœæ typowych Ÿróde³, metod, procedur i dobrych praktyk do realizacji zadañ zwi¹zanych z ró¿nymi sferami dzia³alnoœci pedagogicznej z wykorzystaniem ICT", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U03", Opis = "potrafi wykorzystywaæ wiedzê teoretyczn¹ z zakresu pedagogiki oraz powi¹zanych z ni¹ dyscyplin w celu analizowania i interpretowania problemów edukacyjnych, wychowawczych, opiekuñczych, kulturalnych i pomocowych, a tak¿e motywów i wzorów ludzkich zachowañ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U04", Opis = "potrafi prowadziæ podstawowe badania, dokonaæ obserwacji i interpretacji zjawisk spo³ecznych; analizuje ich powi¹zania z ró¿nymi obszarami dzia³alnoœci pedagogicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U05", Opis = "potrafi pos³ugiwaæ siê ujêciami teoretycznymi w celu analizowania, interpretowania oraz projektowania strategii dzia³añ pedagogicznych; potrafi generowaæ rozwi¹zania konkretnych problemów pedagogicznych i prognozowaæ przebieg ich rozwi¹zywania oraz przewidywaæ skutki planowanych dzia³añ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U06", Opis = "potrafi prawid³owo pos³ugiwaæ siê zasadami i normami etycznymi w podejmowanej dzia³alnoœci, dostrzega i analizuje dylematy etyczne; przewiduje skutki konkretnych dzia³añ pedagogicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U07", Opis = "ma rozwiniête umiejêtnoœci w zakresie komunikacji interpersonalnej, potrafi u¿ywaæ jêzyka specjalistycznego i porozumiewaæ siê w sposób precyzyjny i spójny przy u¿yciu ró¿nych kana³ów i technik komunikacyjnych ze specjalistami w zakresie pedagogiki, jak i z odbiorcami spoza grona specjalistów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U08", Opis = "posiada umiejêtnoœæ prezentowania w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je argumentacj¹ w kontekœcie wybranych perspektyw teoretycznych, pogl¹dów ró¿nych autorów", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U09", Opis = "pos³ugiwaæ siê jêzykiem obcym na poziomie B2 Europejskiego Systemu Opisu Kszta³cenia Jêzykowego w obszarze pedagogiki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U10", Opis = "potrafi animowaæ prace nad rozwojem uczestników procesów pedagogicznych oraz wspieraæ ich samodzielnoœæ w zdobywaniu wiedzy, a tak¿e inspirowaæ do dzia³añ na rzecz uczenia siê przez ca³e ¿ycie oraz potrafi pracowaæ w zespole pe³ni¹c ró¿ne role", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U11", Opis = "potrafi samodzielnie zdobywaæ wiedzê, dokonaæ analizy w³asnych dzia³añ i wskazaæ ewentualne obszary wymagaj¹ce modyfikacji w przysz³ym dzia³aniu i rozwijaæ swoje profesjonalne umiejêtnoœci, korzystaj¹c z ró¿nych Ÿróde³ (w jêzyku rodzimym i obcym) i nowoczesnych technologii (ICT)", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_U12", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K01", Opis = "ma przekonanie o wadze zachowania siê w sposób profesjonalny, refleksji na tematy etyczne i przestrzegania zasad etyki zawodowej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K02", Opis = "jest przygotowany do aktywnego uczestnictwa w grupach, organizacjach i instytucjach realizuj¹cych dzia³ania pedagogiczne i zdolny do porozumiewania siê z osobami bêd¹cymi i niebêd¹cymi specjalistami w danej dziedzinie oraz przyjmowania odpowiedzialnoœci ich dzia³añ", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K03", Opis = "potrafi kompetentnie oceniæ posiadan¹ wiedzê i braki w tym zakresie", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K04", Opis = "rozumie potrzebê ci¹g³ego dokszta³cania siê zawodowego i rozwoju osobistego, wyznacza kierunki w³asnego rozwoju i kszta³cenia", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K05", Opis = "ma przekonanie o sensie, wartoœci i potrzebie inicjowania oraz podejmowania dzia³añ pedagogicznych w œrodowisku spo³ecznym; jest gotowy do podejmowania wyzwañ zawodowych; wykazuje aktywnoœæ, podejmuje trud i odznacza siê wytrwa³oœci¹ w realizacji indywidualnych i zespo³owych dzia³añ profesjonalnych w zakresie pedagogiki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K06", Opis = "dostrzega i formu³uje problemy moralne i dylematy etyczne zwi¹zane z w³asn¹ i cudz¹ prac¹, poszukuje optymalnych rozwi¹zañ, postêpuje zgodnie z zasadami etyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K07", Opis = "jest œwiadomy istnienia etycznego wymiaru w badaniach naukowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K08", Opis = "odpowiedzialnie przygotowuje siê do swojej pracy, projektuje i wykonuje dzia³ania pedagogiczne wykorzystuj¹c myœlenie i dzia³anie w sposób efektywny i przedsiêbiorczy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K09", Opis = "docenia znaczenie kultury dla utrzymania i rozwoju prawid³owych wiêzi w œrodowiskach spo³ecznych i odnosi zdobyt¹ wiedzê do projektowania dzia³añ zawodowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_K10", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W01", Opis = "posiada zaawansowan¹ i uporz¹dkowan¹ wiedzê ogóln¹ i szczegó³ow¹ w zakresie pedagogiki i jej subdyscyplin obejmuj¹c¹ fakty i zjawiska oraz metody i teorie pedagogiczne, a tak¿e zale¿noœci miêdzy nimi (zna terminologiê, teoriê i metodykê)", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W02", Opis = "ma pog³êbion¹ i uporz¹dkowan¹ wiedzê o wspó³czesnych kierunkach rozwoju pedagogiki, jej nurtach i systemach pedagogicznych, rozumie ich historyczne i kulturowe uwarunkowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W03", Opis = "ma uporz¹dkowan¹ wiedzê na temat teorii wychowania, uczenia siê i nauczania oraz innych procesów edukacyjnych oraz kierunkach rozwoju", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W04", Opis = "posiada pog³êbion¹ wiedzê z zakresu metodologii badañ stosowanych w naukach spo³ecznych i humanistycznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W05", Opis = "ma rozszerzon¹ wiedzê o Ÿród³ach, miejscu i znaczeniu pedagogiki w systemie nauk oraz o jej przedmiotowych i metodologicznych powi¹zaniach z innymi dyscyplinami nauk", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W06", Opis = "ma pog³êbion¹ wiedzê na temat rozwoju cz³owieka w cyklu ¿ycia zarówno w aspekcie biologicznym, psychologicznym jak i spo³ecznym oraz o rodzajach wiêzi spo³ecznych i rz¹dz¹cych nimi prawid³owoœciach z punktu widzenia procesów kulturowych i edukacyjnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W07", Opis = "zna i rozumie jakie jest praktyczne wykorzystanie wiedzy z zakresu nauk humanistycznych i spo³ecznych w dzia³alnoœci edukacyjnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W08", Opis = "posiada zaawansowan¹ wiedzê o metodach analizy i interpretacji kulturowych uwarunkowañ procesów edukacyjnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W09", Opis = "ma wiedzê dotycz¹c¹ zagro¿eñ wspó³czesnej cywilizacji i ich wp³ywu na wychowanie i procesy edukacyjne", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W10", Opis = "ma uporz¹dkowan¹ wiedzê o ekonomicznych, prawnych i etycznych uwarunkowaniach zwi¹zanych z edukacj¹, w tym przepisów dotycz¹cych ochrony w³asnoœci intelektualnej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W11", Opis = "posiada wiedzê dotycz¹c¹ zarz¹dzania zasobami w³asnoœci intelektualnej oraz zna formy i zasady prowadzenia indywidualnej dzia³alnoœci gospodarczej oraz Ÿród³a przepisów i rozwi¹zañ prawnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W12", Opis = "ma uporz¹dkowan¹ wiedzê o celach, strukturze i zasadach funkcjonowania systemów oraz instytucji edukacyjnych, wychowawczych, opiekuñczych, terapeutycznych, kulturalnych, rewaliduj¹cych i resocjalizuj¹cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_W13", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywaæ i integrowaæ wiedzê teoretyczn¹ z zakresu pedagogiki oraz powi¹zanych z ni¹ dyscyplin w celu analizy z³o¿onych problemów edukacyjnych, wychowawczych, opiekuñczych, kulturalnych, pomocowych i terapeutycznych, a tak¿e diagnozowania i projektowania rozwi¹zañ i dzia³añ praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U02", Opis = "potrafi twórczo animowaæ prace nad w³asnym rozwojem oraz rozwojem uczestników procesów edukacyjno-wychowawczych oraz wspieraæ ich samodzielnoœæ w zdobywaniu wiedzy a tak¿e inspirowaæ do dzia³añ na rzecz uczenia siê przez ca³e ¿ycie", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U03", Opis = "potrafi, w oparciu o posiadan¹ wiedzê i umiejêtnoœci oraz dobór w³aœciwych technik, metod i narzêdzi komunikacyjnych porozumiewaæ siê z szerokim gronem odbiorców", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U04", Opis = "potrafi w sposób spójny i precyzyjny prezentowaæ w³asne stanowisko uzasadnione rozbudowan¹ argumentacj¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U05", Opis = "potrafi dokonaæ analizy i oceny problemów pedagogicznych i generowaæ oryginalne ich rozwi¹zania oraz prognozowaæ przebieg oraz przewidywaæ skutki planowanych dzia³añ w okreœlonych obszarach praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U06", Opis = "potrafi wybraæ i zastosowaæ w³aœciwy dla danej dzia³alnoœci sposób postêpowania, dobraæ odpowiednie metody, œrodki i techniki (w tym zaawansowane techniki informacyjno-komunikacyjne) w celu efektywnej realizacji zadañ zawodowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U07", Opis = "posiada pog³êbione umiejêtnoœci identyfikowania i interpretowania zjawisk oraz procesów spo³ecznych, a tak¿e dostrzegania relacji miêdzy nimi z punktu widzenia problemów edukacyjnych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U08", Opis = "potrafi pos³ugiwaæ siê systemami normatywnymi w celu rozwi¹zywania problemów edukacyjnych, wychowawczych, opiekuñczych, terapeutycznych, pomocowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U09", Opis = "potrafi analizowaæ, prognozowaæ i modelowaæ z³o¿one procesy spo³eczne z wykorzystaniem zaawansowanych metod i narzêdzi stosowanych w naukach spo³ecznych i humanistycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U10", Opis = "posiada rozwiniête umiejêtnoœci badawcze: rozró¿nia orientacje w metodologii badañ pedagogicznych, formu³uje problemy badawcze, dobiera adekwatne metody, techniki i konstruuje narzêdzia badawcze", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U11", Opis = "opracowuje, prezentuje i interpretuje wyniki badañ, wyci¹ga wnioski, wskazuje kierunki dalszych badañ, w obrêbie wybranej subdyscypliny pedagogiki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U12", Opis = "potrafi w sposób precyzyjny wypowiadaæ siê w mowie i piœmie na tematy dotycz¹ce ró¿nych zagadnieñ pedagogicznych z wykorzystaniem ró¿nych ujêæ teoretycznych, korzystaj¹c zarówno z dorobku pedagogiki, jak i innych dyscyplin naukowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U13", Opis = "posiada umiejêtnoœci jêzykowe w³aœciwe dla kierunku pedagogika, zgodne z wymogami okreœlonymi dla poziomu B2+ Europejskiego Systemu Opisu Kszta³cenia Jêzykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U14", Opis = "potrafi pracowaæ w zespole przyjmuj¹c rolê lidera w celu efektywnego wykonania zadañ zawodowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U15", Opis = "rozumie potrzebê ustawicznego samorozwoju i potrafi podj¹æ dzia³ania nad w³asnym rozwojem oraz rozwojem uczestników procesów edukacyjno-wychowawczych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_U16", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K01", Opis = "potrafi okreœliæ wartoœci, cele i zadania realizowane w praktyce pedagogicznej i zachowaæ siê w sposób profesjonalny przy jednoczesnym przestrzeganiu zasad etyki zawodowej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K02", Opis = "dostrzega i formu³uje problemy moralne i dylematy etyczne zwi¹zane z w³asn¹ i cudz¹ prac¹, poszukuje optymalnych rozwi¹zañ i mo¿liwoœci korygowania nieprawid³owych dzia³añ pedagogicznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K03", Opis = "potrafi pracowaæ w zespole, a tak¿e pe³niæ rolê lidera", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K04", Opis = "odznacza siê rozwag¹ i dojrza³oœci¹ w odbiorze treœci oraz rozumie koniecznoœæ ich w³aœciwego doboru", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K05", Opis = "pos³uguje siê wiedz¹ praktyczn¹ w celu definiowania i analizy podejmowanych dzia³añ praktycznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K06", Opis = "jest przekonany o sensie, wartoœci i potrzebie podejmowania dzia³añ w œrodowisku spo³ecznym; jest gotowy do podejmowania wyzwañ zawodowych; wykazuje aktywnoœæ, podejmuje trud i odznacza siê wytrwa³oœci¹ w realizacji indywidualnych i zespo³owych zadañ zawodowych wynikaj¹cych z roli pedagoga", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K07", Opis = "jest gotowy do inicjowania i podejmowania indywidualnych i zespo³owych dzia³añ na rzecz podnoszenia jakoœci pracy szko³y lub innych instytucji edukacyjnych, opiekuñczych i wychowawczych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K08", Opis = "jest gotowy do podejmowania wyzwañ zawodowych i osobistych; rozumie istotê i potrzebê przedsiêbiorczej postawy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K09", Opis = "docenia znaczenie nauk pedagogicznych dla rozwoju jednostki i prawid³owych wiêzi w œrodowiskach spo³ecznych, ma pozytywne nastawienie do nabywania wiedzy z zakresu studiowanej dyscypliny naukowej i budowania warsztatu pracy pedagoga", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K10", Opis = "Jest przekonany o koniecznoœci i donios³oœci zachowania siê w sposób profesjonalny i przestrzegania zasad etyki zawodowej; dostrzega i formu³uje problemy moralne i dylematy etyczne zwi¹zane z w³asn¹ i cudz¹ prac¹; poszukuje optymalnych rozwi¹zañ i mo¿liwoœci korygowania nieprawid³owych dzia³añ pedagogicznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K11", Opis = "Jest gotowy do uczestniczenia w ¿yciu kulturalnym i korzystania z jego ró¿norodnych form i dorobku w celu rozwijania w³asnych kompetencji pedagogicznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_K12", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzial WF w P³ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W01", Opis = "posiada podstawow¹ wiedzê w zakresie fizykochemicznych i biologicznych podstaw wychowania fizycznego oraz zdrowotnego dzieci i m³odzie¿y", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W02", Opis = "posiada podstawow¹ wiedzê o budowie oraz funkcjach organizmu cz³owieka, a szczególnie o funkcjonowaniu organizmu podczas wysi³ku fizycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W03", Opis = "zna podstawowe metody oceny zdolnoœci wysi³kowych, kondycyjnych i koordynacyjnych cz³owieka, metody oceny stanu rozwoju fizycznego dzieci i m³odzie¿y oraz czynniki determinuj¹ce ten rozwój", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W04", Opis = "zna podstawowe pojêcia i mechanizmy psychospo³eczne zwi¹zane ze zdrowiem oraz ochron¹ zdrowia i sprawnoœci psychofizycznej cz³owieka", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W05", Opis = "zna teoretyczne podstawy dzia³añ interwencyjnych wobec jednostek oraz grup spo³ecznych w zakresie udzielania pierwszej pomocy, przeciwdzia³ania agresji fizycznej oraz zapobiegania patologiom spo³ecznym wystêpuj¹cym wœród dzieci i m³odzie¿y", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W06", Opis = "zna zasady promocji zdrowia i zdrowego trybu (stylu) ¿ycia ze szczególnym uwzglêdnieniem aktywnoœci fizycznej, rekreacji i sportu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W07", Opis = "zna skutki ró¿nych form aktywnoœci ruchowej i jej braku, rozumie procesy adaptacji organizmu do ró¿nych form wysi³ku fizycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W08", Opis = "zna prawne, organizacyjne i etyczne uwarunkowania wykonywania dzia³alnoœci zawodowej nauczyciela wychowania fizycznego i dydaktyka sportu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W09", Opis = "zna miejsce dziedziny nauk o kulturze fizycznej, znaczenie i miejsce wychowania fizycznego i zdrowotnego w ramach krajowego systemu ochrony zdrowia", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W10", Opis = "ma podstawow¹ wiedzê i zna terminologiê nauk o kulturze fizycznej w zakresie niezbêdnym do wykonywania zawodu nauczyciela wychowania fizycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W11", Opis = "zna i rozumie podstawowe pojêcia i zasady z zakresu ochrony w³asnoœci przemys³owej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W12", Opis = "zna ogólne zasady tworzenia i rozwoju form indywidualnej przedsiêbiorczoœci, wykorzystuj¹cej wiedzê z zakresu kultury fizycznej, a w szczególnoœci z zakresu wychowania fizycznego i zdrowotnego, rekreacji oraz sportu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "U_W13", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U01", Opis = "posiada niezbêdne umiejêtnoœci w zakresie zapewnienia bezpieczeñstwa uczniów, udzielania pierwszej pomocy przedmedycznej, oceny jakoœci œrodowiska zajêæ, u¿ywanych urz¹dzeñ sportowych, sprzêtu i przyborów, w zakresie ich przechowywania i podstawowych zasad konserwacji", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U02", Opis = "potrafi pos³ugiwaæ siê podstawowym sprzêtem, przyborami, urz¹dzeniami stosowanymi w wychowaniu fizycznym i sporcie, potrafi korzystaæ z dostêpnej bazy sportowej i rekreacyjnej, jak sale do æwiczeñ fizycznych, boiska, baseny itp.", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U03", Opis = "potrafi komunikowaæ siê z jednostk¹ oraz grup¹ spo³eczn¹ w zakresie zwi¹zanym z wychowaniem fizycznym, zdrowotnym, sportem i rekreacj¹ fizyczn¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U04", Opis = "potrafi identyfikowaæ indywidualne oraz grupowe problemy uczniów w zakresie kultury fizycznej, wychowania fizycznego, zdrowotnego i rekreacji fizycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U05", Opis = "potrafi podj¹æ dzia³ania diagnostyczne, profilaktyczne, pielêgnacyjne, terapeutyczne i edukacyjne odpowiadaj¹ce potrzebom jednostki oraz grupy spo³ecznej w³aœciwe dla wychowania fizycznego i ró¿nych form fizycznej rekreacji", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U06", Opis = "potrafi korzystaæ z technik informacyjnych w celu pozyskiwania i przechowywania danych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U07", Opis = "potrafi identyfikowaæ b³êdy i zaniedbania w praktyce dydaktycznej zwi¹zanej z wykonywaniem zawodu nauczyciela wychowania fizycznego i zdrowotnego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U08", Opis = "potrafi interpretowaæ dane liczbowe zwi¹zane z zawodem nauczyciela wychowania fizycznego dotycz¹ce wyników pomiarów antropometrycznych, wyników prób (testów) sprawnoœci fizycznej oraz dane zwi¹zane z ró¿nymi charakterystykami i efektami wysi³ku fizycznego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U09", Opis = "potrafi prowadziæ dokumentacjê dotycz¹c¹ planowania, realizacji i oceny efektów pracy dydaktyczno-wychowawczej nauczyciela wychowania fizycznego w wymiarze indywidualnym, grupowym oraz instytucjonalnym", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U10", Opis = "potrafi planowaæ, projektowaæ i realizowaæ dzia³ania z zakresu wychowania fizycznego i zdrowotnego oraz rekreacji fizycznej z uwzglêdnieniem obowi¹zuj¹cych norm oraz dostêpnych warunków", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U11", Opis = "posiada umiejêtnoœci ruchowe z zakresu utylitarnych form ruchu (p³ywanie z elementami ratownictwa wodnego, bezpieczne upadanie i podstawowe umiejêtnoœci samoobrony, jazda na rowerze, na nartach, lekkoatletyka, p³ywanie na kajaku itp.) oraz umiejêtnoœci ruchowe i sprawnoœæ motoryczn¹ zapewniaj¹ce realizacjê hedonistycznych oraz ludycznych potrzeb cz³owieka (gry i zabawy ruchowe, zespo³owe gry sportowe, tañce oraz nowoczesne formy gimnastyczno-taneczne itp.)", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U12", Opis = "posiada umiejêtnoœæ przygotowania pisemnego raportu w oparciu o w³asne dzia³ania lub dane Ÿród³owe", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U13", Opis = "posiada umiejêtnoœæ prezentowania w formie ustnej wyników w³asnych dzia³añ i przemyœleñ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U14", Opis = "ma umiejêtnoœci jêzykowe w zakresie wychowania fizycznego, rekreacji i sportu, zgodne z wymaganiami okreœlonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta³cenia Jêzykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "U_U15", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K01", Opis = "rozumie potrzebê uczenia siê przez ca³e ¿ycie, potrzebê pog³êbiania w³asnej wiedzy oraz umiejêtnoœci zawodowych, d¹¿y do rozwoju warsztatu pracy nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K02", Opis = "posiada œwiadomoœæ w³asnych ograniczeñ i wie, kiedy zwróciæ siê do ekspertów", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K03", Opis = "okazuje szacunek wobec uczniów i innych osób, wobec grup spo³ecznych, troszczy siê o ich dobro i dobro wspólne", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K04", Opis = "potrafi wspó³dzia³aæ i pracowaæ w grupie, przyjmuj¹c w niej ró¿ne role", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K05", Opis = "potrafi odpowiednio okreœliæ priorytety s³u¿¹ce realizacji okreœlonego przez siebie lub innych zadania w zakresie kultury fizycznej i wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K06", Opis = "potrafi rozwi¹zywaæ najczêstsze problemy zwi¹zane z wykonywaniem zawodu nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K07", Opis = "realizuje zadania w sposób zapewniaj¹cy bezpieczeñstwo w³asne i otoczenia, w tym przestrzega zasad bezpieczeñstwa pracy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K08", Opis = "potrafi formu³owaæ opinie dotycz¹ce indywidualnych uczniów i grup uczniów, a tak¿e grup spo³ecznych w kontekœcie zwi¹zanym z wykonywaniem zawodu nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K09", Opis = "dba o wizerunek w³asnej osoby i poziom sprawnoœci fizycznej niezbêdnej dla wykonywania zadañ zwi¹zanych z zawodem nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "U_K10", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //wydzial zrzazdania w plocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W01", Opis = "ma elementarn¹ wiedzê o miejscu zarz¹dzania w systemie nauk oraz jej powi¹zaniach z innymi dyscyplinami naukowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W02", Opis = "zna elementarn¹ terminologiê stosowan¹ w zarz¹dzaniu i rozumie jej Ÿród³a oraz relacje do terminologii z pokrewnych dyscyplin naukowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W03", Opis = "rozumie zasady, prawid³owoœci i instrumenty zarz¹dzania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W04", Opis = "posiada elementarn¹ wiedzê o podstawowych elementach ró¿nych rodzajów struktur spo³ecznych i instytucji ¿ycia spo³ecznego i gospodarczego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W05", Opis = "rozumie istotê i mechanizmy funkcjonowania organizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W06", Opis = "ma elementarn¹ wiedzê o ró¿nych rodzajach struktur spo³ecznych i instytucjach ¿ycia spo³ecznego oraz zachodz¹cych miêdzy nimi relacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W07", Opis = "posiada systemow¹ wiedzê o ró¿nych organizacjach spo³eczno-ekonomicznych, ich specyfice i wzajemnych uwarunkowaniach ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W08", Opis = "ma podstawow¹ wiedzê o na temat funkcjonowania cz³owieka w organizacjach, zarówno w aspekcie socjologicznym, jak i psychologicznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W09", Opis = "ma podstawow¹ wiedzê o rodzajach wiêzi spo³ecznych i rz¹dz¹cych nimi prawid³owoœciach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W10", Opis = "ma podstawow¹ wiedzê o uczestnikach dzia³alnoœci gospodarczej w skali mikro jak i makro", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W11", Opis = "ma podstawow¹ wiedzê na temat cz³owieka, zarówno w aspekcie socjologicznym, jak i psychologicznym oraz o specyfice jego funkcjonowania w organizacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W12", Opis = "ma elementarn¹ wiedzê o projektowaniu i prowadzeniu badañ z zakresu zarz¹dzania, a w szczególnoœci o problemach badawczych, metodach, technikach i narzêdziach badawczych; zna podstawowe zasady i metody badañ spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W13", Opis = "ma uporz¹dkowan¹ wiedzê na temat zasad i norm etycznych i spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W14", Opis = "ma elementarn¹ wiedzê o bezpieczeñstwie i higienie pracy w organizacjach oraz wiedzê na temat bezpieczeñstwa publicznego oraz zapobiegania i zarz¹dzania sytuacjami kryzysowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W15", Opis = "ma podstawow¹, uporz¹dkowan¹ wiedzê na temat zasad zarz¹dzania zmianami w organizacjach, przyczyn, procesów i wynikaj¹cych z nich skutków", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W16", Opis = "ma podstawow¹ wiedzê o wspó³czesnych pogl¹dach oraz ich ewolucji, na temat wybranych struktur organizacji, instytucji i podmiotów gospodarczych oraz wiêzi spo³ecznych w nich funkcjonuj¹cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W17", Opis = "ma podstawow¹ wiedzê na temat praw autorskich, prawa wynalazczego i patentowego i rozumie zasady ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W18", Opis = "rozumie pojêcie przedsiêbiorczoœci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W19", Opis = "ma podstawow¹ wiedzê na temat tworzenia i rozwoju form przedsiêbiorczoœci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_W20", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywaæ podstawow¹ wiedzê teoretyczn¹ z zakresu zarz¹dzania oraz powi¹zanych z ni¹ dyscyplin w celu interpretowania zjawisk i problemów spo³ecznych i ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U02", Opis = "potrafi wykorzystywaæ podstawow¹ wiedzê teoretyczn¹ z zakresu zarz¹dzania oraz powi¹zanych z ni¹ dyscyplin w celu opisywania i praktycznego analizowania jednostkowych procesów i zjawisk spo³eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U03", Opis = "posiada elementarne umiejêtnoœci badawcze pozwalaj¹ce na analizowanie przyk³adów badañ oraz konstruowanie i prowadzenie prostych badañ empirycznych, potrafi opracowaæ i zaprezentowaæ ich wyniki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U04", Opis = "potrafi w³aœciwie analizowaæ przyczyny i przebieg wybranych procesów i zjawisk spo³eczno-ekonomicznych w obszarze zarz¹dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U05", Opis = "potrafi pos³ugiwaæ siê podstawowymi ujêciami teoretycznymi w celu analizowania motywów i wzorów ludzkich zachowañ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U06", Opis = "potrafi wykorzystaæ standardowe metody i narzêdzia badawcze w celu prognozowania praktycznych skutków procesów i zjawisk spo³eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U07", Opis = "potrafi generowaæ rozwi¹zania konkretnych problemów gospodarczych i prognozowaæ przebieg ich rozwi¹zywania oraz przewidywaæ skutki planowanych dzia³añ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U08", Opis = "potrafi pos³ugiwaæ siê wybranymi regu³ami prawnymi w rozwi¹zywaniu konkretnych zadañ z zakresu zarz¹dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U09", Opis = "potrafi pos³ugiwaæ siê regu³ami zawodowymi i normami etycznymi oraz dostrzega i analizuje dylematy etyczne w prowadzonej dzia³alnoœci", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U10", Opis = "potrafi powi¹zaæ posiadan¹ wiedzê teoretyczn¹ z zakresu zarz¹dzania z praktycznymi umiejêtnoœciami i doœwiadczeniami nabytymi podczas praktyki zawodowej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U11", Opis = "potrafi inspirowaæ procesy gospodarcze, animowaæ prace nad rozwojem uczestników procesów zarz¹dzania oraz wspieraæ ich samodzielnoœæ w zdobywaniu wiedzy", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U12", Opis = "potrafi oceniæ przydatnoœæ typowych metod, procedur i odpowiednich praktyk do realizacji zadañ zwi¹zanych z ró¿nymi sferami dzia³alnoœci spo³eczno-ekonomicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U13", Opis = "posiada umiejêtnoœæ prezentowania w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je w³aœciw¹ argumentacj¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U14", Opis = "potrafi dokonaæ obserwacji zjawisk spo³ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U15", Opis = "potrafi w³aœciwie analizowaæ i interpretowaæ zaobserwowane zjawiska spo³eczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U16", Opis = "posiada umiejêtnoœæ sporz¹dzania prac pisemnych w jêzyku polskim i wybranym jêzyku obcym, traktuj¹cych o wybranych zagadnieniach szczegó³owych z zakresu zarz¹dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U17", Opis = "posiada umiejêtnoœæ prezentowania w formie pisemnej w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je argumentacj¹ w kontekœcie wybranych ujêæ teoretycznych z wykorzystaniem ró¿nych Ÿróde³", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U18", Opis = "posiada umiejêtnoœæ swobodnej wypowiedzi w jêzyku polskim i wybranym jêzyku obcym, traktuj¹cych o wybranych zagadnieniach szczegó³owych z zakresu zarz¹dzania, wi¹¿¹c je z dyscyplinami pokrewnymi", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U19", Opis = "posiada umiejêtnoœæ prezentowania w formie ustnej w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je argumentacj¹ w kontekœcie wybranych ujêæ teoretycznych z wykorzystaniem ró¿nych Ÿróde³", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U20", Opis = "posiada umiejêtnoœæ swobodnej wypowiedzi w mowie i piœmie w zakresie zarz¹dzania, zgodnie z wymaganiami okreœlonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta³cenia Jêzykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_U21", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K01", Opis = "ma œwiadomoœæ poziomu swojej wiedzy i umiejêtnoœci, rozumie potrzebê sta³ego dokszta³cania zawodowego i rozwoju osobistego, dokonuje samooceny w³asnych kompetencji i doskonali umiejêtnoœci, wyznacza kierunki w³asnego rozwoju i samokszta³cenia", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K02", Opis = "potrafi dokonaæ analizy w³asnych dzia³añ i wskazaæ ewentualne obszary wymagaj¹ce modyfikacji w przysz³ym dzia³aniu", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K03", Opis = "jest przygotowany do aktywnego uczestnictwa i pracy w zespo³ach zadaniowych, organizacjach i instytucjach realizuj¹cych dzia³ania gospodarcze", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K04", Opis = "potrafi siê elastycznie dostosowaæ do pe³nienia ró¿nych funkcji w zespo³ach zadaniowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K05", Opis = "jest przygotowany do kierowania zespo³ami zadaniowymi", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K06", Opis = "jest œwiadomy hierarchii i stratyfikacji priorytetów i jest w stanie dokonywaæ optymalnego wyboru priorytetów przy planowaniu zadañ dla siebie oraz dla innych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K07", Opis = "ma przekonanie o wadze zachowania siê w sposób profesjonalny, przestrzegania zasad etyki menad¿erskiej oraz spo³ecznej odpowiedzialnoœci organizacji", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K08", Opis = "dostrzega i formu³uje problemy moralne i dylematy etyczne zwi¹zane z w³asn¹ i cudz¹ prac¹, poszukuje optymalnych rozwi¹zañ, postêpuje zgodnie z zasadami etyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K09", Opis = "odpowiedzialnie przygotowuje siê do swojej pracy, projektuje i wykonuje dzia³ania w obszarze zarz¹dzania posi³kuj¹c siê analiz¹ systemow¹ i wielokryterialn¹", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K10", Opis = "ma œwiadomoœæ zasad i nowoczesnych instrumentów zarz¹dzania projektami", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K11", Opis = "ma przekonanie o potrzebie ci¹g³ego uzupe³niania i doskonalenia w³asnej wiedzy i umiejêtnoœci, jest w stanie w³aœciwie zidentyfikowaæ jej Ÿród³a i zakres", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K12", Opis = "ma przekonanie o sensie, wartoœci i potrzebie podejmowania dzia³añ gospodarczych w œrodowisku spo³ecznym; jest gotowy do podejmowania wyzwañ zawodowych; wykazuje aktywnoœæ, podejmuje trud i odznacza siê wytrwa³oœci¹ w realizacji indywidualnych i zespo³owych dzia³añ profesjonalnych w zakresie zarz¹dzania, uwzglêdniaj¹c teoretyczne i praktyczne przes³anki zarz¹dzania ryzykiem", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_K13", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W01", Opis = "ma rozszerzon¹ wiedzê o miejscu zarz¹dzania w systemie nauk oraz jej powi¹zaniach z innymi dyscyplinami naukowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W02", Opis = "zna poszerzon¹ terminologiê stosowan¹ w zarz¹dzaniu i rozumie jej Ÿród³a oraz relacje do terminologii z pokrewnych dyscyplin naukowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W03", Opis = "rozumie zasady, prawid³owoœci i instrumenty zarz¹dzania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W04", Opis = "posiada rozszerzon¹ wiedzê o podstawowych elementach ró¿nych rodzajów struktur spo³ecznych i instytucji ¿ycia spo³ecznego i gospodarczego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W05", Opis = "rozumie istotê i mechanizmy funkcjonowania organizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W06", Opis = "ma pog³êbion¹ wiedzê o ró¿nych rodzajach struktur spo³ecznych i instytucjach ¿ycia spo³ecznego oraz zachodz¹cych miêdzy nimi relacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W07", Opis = "posiada systemow¹ wiedzê o ró¿nych organizacjach spo³eczno-ekonomicznych, ich specyfice i wzajemnych uwarunkowaniach ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W08", Opis = "ma rozszerzon¹ wiedzê o na temat funkcjonowania cz³owieka w organizacjach, zarówno w aspekcie socjologicznym, jak i psychologicznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W09", Opis = "ma rozszerzon¹ wiedzê o rodzajach wiêzi spo³ecznych i rz¹dz¹cych nimi prawid³owoœciach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W10", Opis = "ma rozszerzon¹ wiedzê o uczestnikach dzia³alnoœci gospodarczej w skali mikro jak i makro", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W11", Opis = "ma wiedzê na temat cz³owieka, zarówno w aspekcie socjologicznym, jak i psychologicznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W12", Opis = "ma pog³êbion¹ wiedzê o specyfice funkcjonowania cz³owieka w organizacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W13", Opis = "ma pog³êbion¹ wiedzê o projektowaniu i prowadzeniu badañ z zakresu zarz¹dzania, a w szczególnoœci o problemach badawczych, metodach, technikach i narzêdziach badawczych; zna podstawowe zasady i metody badañ spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W14", Opis = "ma uporz¹dkowan¹ wiedzê na temat zasad i norm etycznych i spo³ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W15", Opis = "ma pog³êbion¹ wiedzê o bezpieczeñstwie i higienie pracy w organizacjach, wiedzê na temat bezpieczeñstwa publicznego oraz zapobiegania i zarz¹dzania sytuacjami kryzysowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W16", Opis = "ma pog³êbion¹, uporz¹dkowan¹ wiedzê na temat zasad zarz¹dzania zmianami w organizacjach, przyczyn, procesów i wynikaj¹cych z nich skutków", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W17", Opis = "ma pog³êbion¹ wiedzê o wspó³czesnych pogl¹dach oraz ich ewolucji, na temat wybranych struktur organizacji, instytucji i podmiotów gospodarczych oraz wiêzi spo³ecznych w nich funkcjonuj¹cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W18", Opis = "ma podstawow¹ wiedzê na temat praw autorskich, prawa wynalazczego i patentowego i rozumie zasady ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W19", Opis = "rozumie pojêcie przedsiêbiorczoœci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W20", Opis = "ma podstawow¹ wiedzê na temat tworzenia i rozwoju form przedsiêbiorczoœci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_W21", Opis = "posiada wiedzê zarówno z dziedziny nauk humanistycznych i spo³ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywaæ podstawow¹ wiedzê teoretyczn¹ z zakresu zarz¹dzania oraz powi¹zanych z ni¹ dyscyplin w celu interpretowania zjawisk i problemów spo³ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U02", Opis = "potrafi wykorzystywaæ wiedzê teoretyczn¹ z zakresu zarz¹dzania oraz powi¹zanych z ni¹ dyscyplin w celu opisywania i praktycznego analizowania jednostkowych procesów i zjawisk spo³eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U03", Opis = "posiada elementarne umiejêtnoœci badawcze pozwalaj¹ce na analizowanie przyk³adów badañ oraz konstruowanie i prowadzenie prostych badañ empirycznych, potrafi opracowaæ i zaprezentowaæ ich wyniki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U04", Opis = "potrafi krytycznie dobieraæ gromadzone dane i metody badawcze w celu formu³owania w³asnych wniosków i opinii", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U05", Opis = "potrafi w³aœciwie analizowaæ przyczyny i przebieg wybranych procesów i zjawisk spo³eczno-ekonomicznych w obszarze zarz¹dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U06", Opis = "potrafi pos³ugiwaæ siê podstawowymi ujêciami teoretycznymi w celu analizowania motywów i wzorów ludzkich zachowañ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U07", Opis = "potrafi stawiaæ proste hipotezy badawcze oraz je weryfikowaæ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U08", Opis = "potrafi wykorzystaæ standardowe metody i narzêdzia badawcze w celu prognozowania praktycznych skutków procesów i zjawisk spo³eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U09", Opis = "potrafi konstruowaæ proste modele procesów spo³ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U10", Opis = "potrafi generowaæ rozwi¹zania konkretnych problemów gospodarczych i prognozowaæ przebieg ich rozwi¹zywania oraz przewidywaæ skutki planowanych dzia³añ", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U11", Opis = "potrafi pos³ugiwaæ siê wybranymi regu³ami prawnymi w rozwi¹zywaniu konkretnych zadañ z zakresu zarz¹dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U12", Opis = "potrafi pos³ugiwaæ siê regu³ami zawodowymi i normami etycznymi oraz dostrzega i analizuje dylematy etyczne w podejmowanej dzia³alnoœci", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U13", Opis = "potrafi powi¹zaæ posiadan¹ wiedzê teoretyczn¹ z zakresu zarz¹dzania z praktycznymi umiejêtnoœciami i doœwiadczeniami nabytymi podczas praktyki zawodowej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U14", Opis = "potrafi inspirowaæ procesy gospodarcze, animowaæ prace nad rozwojem uczestników procesów zarz¹dzania oraz wspieraæ ich samodzielnoœæ w zdobywaniu wiedzy", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U15", Opis = "potrafi oceniæ przydatnoœæ typowych metod, procedur i odpowiednich praktyk do realizacji zadañ zwi¹zanych z ró¿nymi sferami dzia³alnoœci spo³eczno-ekonomicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U16", Opis = "posiada umiejêtnoœæ prezentowania w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je w³aœciw¹ argumentacj¹", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U17", Opis = "potrafi dokonaæ obserwacji zjawisk spo³ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U18", Opis = "potrafi w³aœciwie analizowaæ i interpretowaæ zaobserwowane zjawiska spo³eczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U19", Opis = "potrafi zaobserwowane i zinterpretowane zjawiska poddaæ pog³êbionej ocenie teoretycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U20", Opis = "posiada pog³êbion¹ umiejêtnoœæ sporz¹dzania prac pisemnych w jêzyku polskim i wybranym jêzyku obcym, traktuj¹cych o wybranych zagadnieniach szczegó³owych z zakresu zarz¹dzania oraz dziedzin pokrewnych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U21", Opis = "posiada umiejêtnoœæ prezentowania w formie pisemnej w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je argumentacj¹ w kontekœcie wybranych ujêæ teoretycznych z wykorzystaniem ró¿nych Ÿróde³", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U22", Opis = "posiada pog³êbion¹ umiejêtnoœæ swobodnej wypowiedzi w jêzyku polskim i wybranym jêzyku obcym, traktuj¹cych o wybranych zagadnieniach szczegó³owych z zakresu zarz¹dzania, wi¹¿¹c je z dyscyplinami pokrewnymi", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U23", Opis = "posiada umiejêtnoœæ prezentowania w formie ustnej w³asnych pomys³ów, w¹tpliwoœci i sugestii, popieraj¹c je argumentacj¹ w kontekœcie wybranych ujêæ teoretycznych z wykorzystaniem ró¿nych Ÿróde³", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U24", Opis = "posiada umiejêtnoœæ swobodnej wypowiedzi w mowie i piœmie w zakresie zarz¹dzania, zgodnie z wymaganiami okreœlonymi dla poziomu B2+ Europejskiego Systemu Opisu Kszta³cenia Jêzykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_U25", Opis = "potrafi przystosowaæ siê do dynamicznie zmieniaj¹cego siê rynku pracy, dziêki posiadaniu wiedzy ogólnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K01", Opis = "ma œwiadomoœæ poziomu swojej wiedzy i umiejêtnoœci, rozumie potrzebê sta³ego dokszta³cania zawodowego i rozwoju osobistego, dokonuje samooceny w³asnych kompetencji i doskonali umiejêtnoœci, wyznacza kierunki w³asnego rozwoju i samokszta³cenia", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K02", Opis = "potrafi dokonaæ analizy w³asnych dzia³añ i wskazaæ ewentualne obszary wymagaj¹ce modyfikacji w przysz³ym dzia³aniu", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K03", Opis = "jest przygotowany do aktywnego uczestnictwa i pracy w zespo³ach zadaniowych, organizacjach i instytucjach realizuj¹cych dzia³ania gospodarcze", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K04", Opis = "potrafi siê elastycznie dostosowaæ do pe³nienia ró¿nych funkcji w zespo³ach zadaniowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K05", Opis = "jest przygotowany do kierowania zespo³ami zadaniowymi", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K06", Opis = "jest œwiadomy hierarchii i stratyfikacji priorytetów i jest w stanie dokonywaæ optymalnego wyboru priorytetów przy planowaniu zadañ dla siebie oraz dla innych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K07", Opis = "ma przekonanie o wadze zachowania siê w sposób profesjonalny, przestrzegania zasad etyki menad¿erskiej oraz spo³ecznej odpowiedzialnoœci organizacji", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K08", Opis = "dostrzega i formu³uje problemy moralne i dylematy etyczne zwi¹zane z w³asn¹ i cudz¹ prac¹, poszukuje optymalnych rozwi¹zañ, postêpuje zgodnie z zasadami etyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K09", Opis = "odpowiedzialnie przygotowuje siê do swojej pracy, projektuje i wykonuje dzia³ania w obszarze zarz¹dzania posi³kuj¹c siê analiz¹ systemow¹ i wielokryterialn¹", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K10", Opis = "ma œwiadomoœæ zasad i nowoczesnych instrumentów zarz¹dzania projektami", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K11", Opis = "ma przekonanie o potrzebie ci¹g³ego uzupe³niania i doskonalenia w³asnej wiedzy i umiejêtnoœci, jest w stanie w³aœciwie zidentyfikowaæ jej Ÿród³a i zakres w ujêciu interdyscyplinarnym", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K12", Opis = "ma przekonanie o sensie, wartoœci i potrzebie podejmowania dzia³añ gospodarczych w œrodowisku spo³ecznym; jest gotowy do podejmowania wyzwañ zawodowych; wykazuje aktywnoœæ, podejmuje trud i odznacza siê wytrwa³oœci¹ w realizacji indywidualnych i zespo³owych dzia³añ profesjonalnych w zakresie zarz¹dzania, uwzglêdniaj¹c teoretyczne i praktyczne przes³anki zarz¹dzania ryzykiem", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_K13", Opis = "rozumie potrzebê ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj¹cych spo³eczeñstwo informacyjne, z poszanowaniem praw w³asnoœci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id }


            );

            context.FormyPracy.AddOrUpdate(x => x.FormaPracyId,
                new FormaPracy() { FormaPracyId = 1, Opis = "Zapozanie siê z literatur¹ przedmiotu" },
                new FormaPracy() { FormaPracyId = 2, Opis = "Przygotowanie siê do zajêæ" },
                new FormaPracy() { FormaPracyId = 3, Opis = "Przygotowanie siê do kolokwiów" },
                new FormaPracy() { FormaPracyId = 4, Opis = "Realizacja zadanych æwiczeñ i zadañ" },
                new FormaPracy() { FormaPracyId = 5, Opis = "Przygotowanie sprawozdania z æwiczeñ" },
                new FormaPracy() { FormaPracyId = 6, Opis = "Przygotowanie projektu / pracy" },
                new FormaPracy() { FormaPracyId = 7, Opis = "Przygotowanie siê i udzia³ w egzaminie" }
            );
        }
    }
}
