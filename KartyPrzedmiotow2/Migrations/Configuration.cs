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
                new ProfilKsztalcenia() { Id = 2, Nazwa = "Og�lnouczelniany" }
                );

            context.GrupyPrzedmiotow.AddOrUpdate(x => x.Id,
                new GrupaPrzedmiotow() { Id = 1, Nazwa = "Og�lnouczelniane" },
                new GrupaPrzedmiotow() { Id = 2, Nazwa = "Realizowane na innym kierunku" },
                new GrupaPrzedmiotow() { Id = 3, Nazwa = "Podstawowe" },
                new GrupaPrzedmiotow() { Id = 4, Nazwa = "Kierunkowe" },
                new GrupaPrzedmiotow() { Id = 5, Nazwa = "Wynikaj�ce z organizacji studi�w" },
                new GrupaPrzedmiotow() { Id = 6, Nazwa = "Specjalno�ciowe" }
                );
            context.Materialy.AddOrUpdate(x => x.Id,
                new Material() { Id = 1, Nazwa = "kurs e-learningowy" },
                new Material() { Id = 2, Nazwa = "skrypt" },
                new Material() { Id = 3, Nazwa = "materia�y na platformie" },
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
                new FormaZaliczenia() { Id = 2, Nazwa = "Z - zaliczenie na ocen�" },
                new FormaZaliczenia() { Id = 3, Nazwa = "E - egzamin" }
                );
            context.GrupyMetodDydaktycznych.AddOrUpdate(x => x.Id,
                new GrupyMetodDydaktycznych() { Id = 1, Nazwa = "Podaj�ce" },
                new GrupyMetodDydaktycznych() { Id = 2, Nazwa = "Problemowe" },
                new GrupyMetodDydaktycznych() { Id = 3, Nazwa = "Praktyczne" },
                new GrupyMetodDydaktycznych() { Id = 4, Nazwa = "Eksponuj�ce" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 1, Nazwa = "wyk�ad informacyjny" },
                new MetodyDydaktyczne() { Id = 2, GrupyMetodDydaktycznychId = 1, Nazwa = "opis" },
                new MetodyDydaktyczne() { Id = 3, GrupyMetodDydaktycznychId = 1, Nazwa = "opowiadanie" },
                new MetodyDydaktyczne() { Id = 4, GrupyMetodDydaktycznychId = 1, Nazwa = "pogadanka" },
                new MetodyDydaktyczne() { Id = 5, GrupyMetodDydaktycznychId = 1, Nazwa = "obja�nienie" },
                new MetodyDydaktyczne() { Id = 6, GrupyMetodDydaktycznychId = 1, Nazwa = "praca ze �r�d�em drukowanym" },
                new MetodyDydaktyczne() { Id = 7, GrupyMetodDydaktycznychId = 1, Nazwa = "praca ze �r�d�em elektronicznym" },
                new MetodyDydaktyczne() { Id = 8, GrupyMetodDydaktycznychId = 1, Nazwa = "studium przypadku" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 2, Nazwa = "wyk�ad problemowy" },
                new MetodyDydaktyczne() { Id = 2, GrupyMetodDydaktycznychId = 2, Nazwa = "burza m�zg�w" },
                new MetodyDydaktyczne() { Id = 3, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda sytuacyjna" },
                new MetodyDydaktyczne() { Id = 4, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda inscenizacji" },
                new MetodyDydaktyczne() { Id = 5, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda symulacyjna" },
                new MetodyDydaktyczne() { Id = 6, GrupyMetodDydaktycznychId = 2, Nazwa = "dyskusja dydaktyczna" },
                new MetodyDydaktyczne() { Id = 7, GrupyMetodDydaktycznychId = 2, Nazwa = "metoda badawcza" }
                );
            context.Metody.AddOrUpdate(x => x.Id,
                new MetodyDydaktyczne() { Id = 1, GrupyMetodDydaktycznychId = 3, Nazwa = "�wiczenie praktyczne" },
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
                new MetodyOceniania() { Id = 7, Nazwa = "sprawozdanie z �wicze�" },
                new MetodyOceniania() { Id = 8, Nazwa = "przygotowanie do zaj��" },
                new MetodyOceniania() { Id = 9, Nazwa = "aktywno�� w trakcie zaj��" }
                );
            context.ObszaryKsztalcenia.AddOrUpdate(x => x.Id,
                new ObszarKsztalcenia() { Id = 1, Nazwa = "Obszar nauk humanistycznych" },
                new ObszarKsztalcenia() { Id = 2, Nazwa = "Obszar nauk spo�ecznych" },
                new ObszarKsztalcenia() { Id = 3, Nazwa = "Obszar nauk �cis�ych" },
                new ObszarKsztalcenia() { Id = 4, Nazwa = "Obszar nauk przyrodniczych" },
                new ObszarKsztalcenia() { Id = 5, Nazwa = "Obszar nauk technicznych" },
                new ObszarKsztalcenia() { Id = 6, Nazwa = "Obszar nauk rolniczych, le�nych i weterynaryjnych" },
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
                new TypLiczbaGodzin() { Id = 3, Nazwa = "�wiczenia" },
                new TypLiczbaGodzin() { Id = 4, Nazwa = "Laboratorium" },
                new TypLiczbaGodzin() { Id = 5, Nazwa = "Projekt" },
                new TypLiczbaGodzin() { Id = 6, Nazwa = "Seminarium" },
                new TypLiczbaGodzin() { Id = 7, Nazwa = "Praktyka/Ob�z" }
                );

            context.JezykiObce.AddOrUpdate(x => x.Id,
                new Jezyk() { Id = 1, Nazwa = "Polski" },
                new Jezyk() { Id = 2, Nazwa = "Angielski" },
                new Jezyk() { Id = 3, Nazwa = "Niemiecki" },
                new Jezyk() { Id = 4, Nazwa = "Hiszpa�ski" }
                );

            var mgr = new Tytul() { Id = 1, Nazwa = "mgr", Kolejnosc = 2 };
            var inz = new Tytul() { Id = 2, Nazwa = "in�.", Kolejnosc = 3 };
            var dr = new Tytul() { Id = 3, Nazwa = "dr", Kolejnosc=1 };
            var doc = new Tytul() { Id = 4, Nazwa = "doc", Kolejnosc = 0 };

            context.Tytuly.AddOrUpdate(x => x.Id,
                mgr, inz, dr, doc
                );

            var passwordHasher = new PasswordHasher();

            var dziekan = new IdentityRole("Dziekan");
            var admin = new IdentityRole("Admin");
            var wykladowca = new IdentityRole("Wyk�adowca");
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
                var wykladowca2 = new Uzytkownik() { Id = Guid.NewGuid().ToString(), UserName = "wykladowca2@gmail.com", Imie = "Bartosz", Nazwisko = "D�browski", Email = "wykladowca2@gmail.com", PasswordHash = passwordHasher.HashPassword("123"), SecurityStamp = Guid.NewGuid().ToString() };

                wykladowca2.Tytuly.Add(dr);
                wykladowca2.Tytuly.Add(inz);

                var wykladowcaRole2 = new IdentityUserRole();
                wykladowcaRole2.RoleId = wykladowca.Id;
                wykladowcaRole2.UserId = wykladowca2.Id;
                wykladowca2.Roles.Add(wykladowcaRole2);

                context.Users.Add(wykladowca2);
            }


            var wiedzaEfekt = new RodzajEfektu() { Id = 1, Nazwa = "Wiedza" };
            var umiejetnosciEfekt = new RodzajEfektu() { Id = 2, Nazwa = "Umiej�tno�ci" };
            var kompetencjeEfekt = new RodzajEfektu() { Id = 3, Nazwa = "Kompetencje" };

            context.RodzajeEfektow.AddOrUpdate(x => x.Id,
                wiedzaEfekt,
                umiejetnosciEfekt,
                kompetencjeEfekt
                );

            var wydzialAdmwPlocku = new Wydzial() { Id = 1, Nazwa = "Wydzia� Administracji w P�ocku" };
            var wydzialBezpwPlocku = new Wydzial() { Id = 2, Nazwa = "Wydzia� Bezpiecze�stwa Narodowego w P�ocku" };
            var wydzialInfwPlocku = new Wydzial() { Id = 3, Nazwa = "Wydzia� Informatyki w P�ocku" };
            var wydzialNaukwPlocku = new Wydzial() { Id = 4, Nazwa = "Wydzia� Nauk Spo�ecznych w P�ocku" };
            var wydzialPedwPlocku = new Wydzial() { Id = 5, Nazwa = "Wydzia� Pedagogiczny w P�ocku" };
            var wydzialWfwPlocku = new Wydzial() { Id = 6, Nazwa = "Wydzia� Wychowania Fizycznego w P�ocku" };
            var wydzialZarzawPlocku = new Wydzial() { Id = 7, Nazwa = "Wydzia� Zarz�dzania w P�ocku" };

            var Istlic = new Poziom() { Id = 1, Nazwa = "I st. licencjacki" };
            var IIst = new Poziom() { Id = 3, Nazwa = "II stopnia" };
            var Istinz = new Poziom() { Id = 2, Nazwa = "I st. in�ynierski" };
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
                //new Wydzial() { Id = 8, Nazwa = "Wydzia� Administracji w Wyszkowie" },
                //new Wydzial() { Id = 9, Nazwa = "Wydzia� Pedagogiczny w Wyszkowie" },
                //new Wydzial() { Id = 10, Nazwa = "Wydzia� Piel�gniarstwa w Wyszkowie" },
                //new Wydzial() { Id = 11, Nazwa = "Wydzia� Zarz�dzania w Wyszkowie" },
                //new Wydzial() { Id = 12, Nazwa = "Wydzia� Administracji w I�awie" },
                //new Wydzial() { Id = 13, Nazwa = "Wydzia� Pedagogiczny w I�awie" }
                );

            context.Efekty.AddOrUpdate(x => new { x.PoziomId, x.WydzialId, x.Skrot, x.RodzajEfektuId },
                //Wydzia� Administracji w P�ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W01", Opis = "ma podstawow� wiedz� o istocie nauk o administracji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W02", Opis = "ma podstawow� wiedz� o miejscu nauki o administracji w dziedzinie nauk prawnych oraz obszarze nauk spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W03", Opis = "ma uporz�dkowan� wiedz� o r�nych aspektach �ycia spo�ecznego a w szczeg�lno�ci funkcjonowania administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W04", Opis = "zna podstawowe elementy struktur administracji publicznej oraz sfery �ycia publicznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W05", Opis = "ma podstawow� wiedz� z zakresu organizacji i funkcjonowania administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W06", Opis = "ma podstawow� wiedz� o porz�dku prawnym jako systemie oraz wzajemnych relacjach zachodz�cych w tym systemie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W07", Opis = "zna rodzaje relacji i stosunk�w zachodz�cych w administracji, w szczeg�lno�ci stosunk�w prawnych, organizacyjnych, ekonomicznych oraz spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W08", Opis = "ma podstawow� wiedz� o wzajemnych relacjach pomi�dzy r�nymi podmiotami wykonuj�cymi zadania z zakresu administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W09", Opis = "ma podstawow� wiedz� o prawach i obowi�zkach obywatelskich wynikaj�cych z przepis�w Konstytucji, przepis�w prawa mi�dzynarodowego publicznego oraz przepis�w prawa administracyjnego materialnego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W10", Opis = "ma wiedz� o miejscu i roli jednostki oraz grupy w administracji oraz strukturach pa�stwa, a tak�e instrumentach ich oddzia�ywania na instytucje publiczne", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W11", Opis = "posiada podstawow� wiedz� w zakresie metodologii nauk prawnych, w szczeg�lno�ci nauk o administracji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W12", Opis = "posiada podstawow� wiedz� z zakresu metodologii innych wybranych dyscyplin zaliczanych do obszaru nauk spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W13", Opis = "ma wiedz� w zakresie prawno-ustrojowych podstaw konstytuuj�cych funkcjonowanie pa�stwa, jego organ�w i instytucji ze szczeg�lnym uwzgl�dnieniem administracji publicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W14", Opis = "ma wiedz� o zasadach i regu�ach wewn�trznej organizacji administracji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W15", Opis = "posiada wiedz� o procesach zmian organizacji oraz zasad funkcjonowania struktur pa�stwowych i administracji publicznej. Zna przyczyny, przebieg a tak�e skutki realizacji tych proces�w", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W16", Opis = "zna genez�, przebieg i skutki zmian ustroju pa�stw, organizacji i innych wybranych struktur politycznych w uj�ciu historycznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W17", Opis = "posiada wiedz� o podstawowych nurtach my�li polityczno-prawnej i spo�eczno-ekonomicznej, ze szczeg�lnym uwzgl�dnieniem my�li administracyjnej, a tak�e ich ewolucji oraz kontekstu historycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W18", Opis = "posiada podstawow� wiedz� z zakresu ochrony w�asno�ci przemys�owej i prawa autorskiego oraz rol� administracji w tym zakresie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W19", Opis = "zna podstawowe zasady podejmowania i prowadzenia dzia�alno�ci gospodarczej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_W20", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U01", Opis = "potrafi w�a�ciwie interpretowa� zachodz�ce zjawiska prawne, spo�eczne, ekonomiczne, polityczne i organizacyjne zwi�zane z administracj� publiczn�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U02", Opis = "umie wykorzysta� posiadan� wiedz� teoretyczn� do analizy i rozwi�zania indywidualnego przypadku lub zjawiska wyst�puj�cego w administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U03", Opis = "umie dokona� oceny prawid�owo�ci post�powania organu administracji publicznej w konkretnej sprawie stosuj�c kryteria og�lnie poj�te", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U04", Opis = "potrafi w�a�ciwie analizowa� i interpretowa� przyczyny, przebieg oraz skutki podstawowych proces�w zwi�zanych z administracj� publiczn�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U05", Opis = "potrafi samodzielnie dokona� prostej analizy tekst�w prawnych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U06", Opis = "potrafi podczas praktycznego rozwi�zywania problem�w w administracji wykorzysta� podstawowe metody i narz�dzia w�a�ciwe dla nauk prawnych oraz wybranych nauk spo�ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U07", Opis = "umie stosowa� normy prawne w celu rozwi�zania konkretnego zagadnienia z obszaru administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U08", Opis = "umie stosowa� normy etyki urz�dniczej oraz zasady zawodowe urz�dnika w celu rozwi�zania konkretnego zagadnienia z obszaru administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U09", Opis = "potrafi wykorzysta� podstawow� wiedz� teoretyczn� oraz praktyczn� nabyt� w toku studenckich praktyk zawodowych do dzia�ania na stanowisku administracyjnym w administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U10", Opis = "posiada umiej�tno�� krytycznej analizy oraz wyboru optymalnego rozwi�zania dla konkretnego problemu zwi�zanego z administracj� publiczn�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U11", Opis = "posiada zdolno�� skutecznej implementacji zaproponowanych rozwi�za� w praktyce funkcjonowania administracji", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U12", Opis = "rozumie i potrafi analizowa� zjawiska spo�eczne zwi�zane z administracj� i szeroko rozumianym �yciem publicznym", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U13", Opis = "potrafi przygotowa� si� i wypowiedzie� pisemnie w j�zyku polskim w zakresie zagadnie� zwi�zanych z administracj�, w szczeg�lno�ci stosowa� formalny j�zyk prawny i prawniczy, z wykorzystaniem konstrukcji teoretycznych oraz stosownych �r�de�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U14", Opis = "potrafi przygotowa� si� i wypowiedzie� pisemnie w wybranym j�zyku obcym w zakresie zagadnie� zwi�zanych z administracj�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U15", Opis = "potrafi przygotowa� si� i wypowiedzie� ustnie w j�zyku polskim w zakresie zagadnie� zwi�zanych z administracj�, w szczeg�lno�ci stosowa� j�zyk prawny i prawniczy, z wykorzystaniem konstrukcji teoretycznych oraz stosownych �r�de�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U16", Opis = "potrafi przygotowa� si� i wypowiedzie� ustnie w wybranym j�zyku obcym w zakresie zagadnie� zwi�zanych z administracj�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U17", Opis = "ma umiej�tno�ci j�zykowe w zakresie og�lnym oraz administracji zgodne z wymaganiami okre�lonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta�cenia J�zykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_U18", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K01", Opis = "rozumie potrzeb� uczenia si� przez ca�e �ycie, dostrzega korzy�ci p�yn�ce z podwy�szania kwalifikacji", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K02", Opis = "potrafi wsp�dzia�a� w pracy zespo�owej, przyjmuj�c r�ne role w grupie", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K03", Opis = "potrafi kierowa� niewielkim zespo�em pracownik�w", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K04", Opis = "potrafi wyznacza� priorytety dzia�ania organ�w administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K05", Opis = "prawid�owo identyfikuje i rozstrzyga problemy zwi�zane z efektywnym wykonywaniem zada� pracownika administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K06", Opis = "potrafi aktywnie uczestniczy� w przygotowaniu projekt�w zwi�zanych z zakresem zada� administracji publicznej wraz z ich podstaw� formalno-prawn�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K07", Opis = "rozumie potrzeb� pozyskiwania spo�ecznej akceptacji dla dzia�a� w�adz publicznych, w tym r�wnie� organ�w administracyjnych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K08", Opis = "posiada zdolno�� samodzielnego uzupe�niania i doskonalenia zdobytej wiedzy i umiej�tno�ci z obszaru nauk prawnych oraz wybranych nauk spo�ecznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K09", Opis = "potrafi podejmowa� r�norodne dzia�ania na rzecz rozwoju spo�eczno�ci lokalnych wykorzystuj�c zdobyt� wiedz� z zakresu nauk o administracji i wybranych nauk z obszaru nauk spo�ecznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_K10", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W01", Opis = "zna i rozumie w pog��bionym stopniu - wybrane fakty, obiekty i zjawiska z zakresu administracji publicznej, dotycz�ce ich metody i teorie wyja�niaj�ce zale�no�ci mi�dzy nimi, stanowi�ce podstawow� wiedz� z zakresu dyscyplin naukowych tworz�cych podstawy teoretyczne dla nauk o administracji oraz wybrane zagadnienia z zakresu dziedziny nauk prawnych i obszaru nauk spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W02", Opis = "zna i rozumie g��wne trendy w tym og�ln� metodologi� bada� w zakresie dyscyplin naukowych przypisanych do kierunku administracja", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W03", Opis = "zna i rozumie w pog��bionym stopniu teorie naukowe w�a�ciwe dla kierunku studi�w administracja oraz kierunki ich rozwoju, a tak�e zaawansowan� metodologi� bada�", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W04", Opis = "zna i rozumie w pog��bionym stopniu charakter, miejsce i znaczenie nauk spo�ecznych w systemie nauk oraz ich relacje do innych nauk", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W05", Opis = "zna i rozumie w pog��bionym stopniu cechy cz�owieka jako tw�rcy kultury i podmiotu konstytuuj�cego struktury spo�eczne oraz zasady ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W02", Opis = "zna i rozumie fundamentalne dylematy wsp�czesnej cywilizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W06", Opis = "zna i rozumie ekonomiczne, prawne i inne uwarunkowania r�nych rodzaj�w dzia�a� zwi�zanych z nadan� kwalifikacj�, w tym zasady ochrony w�asno�ci przemys�owej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_W07", Opis = "zna i rozumie zasady zarz�dzania zasobami w�asno�ci intelektualnej oraz formy rozwoju indywidualnej przedsi�biorczo�ci", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_W08", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywa� posiadan� wiedz� � formu�owa� i rozwi�zywa� z�o�one i nietypowe problemy i innowacyjnie wykonywa� zadania w nieprzewidywalnych warunkach przez: - w�a�ciwy dob�r �r�de� oraz informacji z nich pochodz�cych, - dokonywanie oceny, krytycznej analizy, syntezy oraz tw�rczej interpretacji i prezentacji tych informacji; - dob�r oraz stosowanie w�a�ciwych metod i narz�dzi, w tym zaawansowanych technik informacyjno-komunikacyjnych (ICT)", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U02", Opis = "potrafi identyfikowa�, interpretowa� i wyja�nia� z�o�one zjawiska i procesy spo�eczne oraz relacje mi�dzy nimi z wykorzystaniem wiedzy z dyscyplin naukowych przypisanych do kierunku studi�w 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U03", Opis = "potrafi prognozowa� i modelowa� z�o�one procesy spo�eczne oraz ich praktyczne skutki z wykorzystaniem zaawansowanych metod i narz�dzi dyscyplin naukowych w�a�ciwych dla administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U04", Opis = "potrafi prawid�owo pos�ugiwa� si� aktami prawnymi z wykorzystaniem wiedzy z zakresu obowi�zuj�cych rozwi�za� prawnych oraz orzecznictwa s�d�w administracyjnych w�a�ciwych dla kierunku 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U05", Opis = "potrafi prognozowa� praktyczne skutki proces�w i zjawisk w obszarze funkcjonowania administracji publicznej z wykorzystaniem standardowych metod i narz�dzi dyscyplin naukowych w�a�ciwych dla kierunku 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U06", Opis = "potrafi bra� udzia� w dyskursie dotycz�cym problematyki administracji publicznej - przedstawia� i ocenia� odmienne opinie i stanowiska oraz dyskutowa� o nich", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U07", Opis = "potrafi pos�ugiwa� si� j�zykiem obcym na poziomie B2+ Europejskiego Systemu Opisu Kszta�cenia J�zykowego w zakresie specjalistycznej terminologii w�a�ciwej dla kierunku 'administracja'", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U08", Opis = "potrafi planowa� i organizowa� prac� zespo�u w obszarze funkcjonowania administracji publicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_U09", Opis = "potrafi samodzielnie planowa� i realizowa� w�asne uczenie si� przez ca�e �ycie", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_U10", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K01", Opis = "jest got�w do krytycznej oceny odbieranych tre�ci, ze szczeg�lnym uwzgl�dnieniem wiedzy dotycz�cej kierunku 'administracja'", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K02", Opis = "jest got�w do uznawania znaczenia wybranej wiedzy z obszaru nauk spo�ecznych podczas rozwi�zywania problem�w poznawczych i praktycznych pojawiaj�cych si� w dzia�alno�ci administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K03", Opis = "jest got�w do wype�niania zobowi�za� spo�ecznych oraz wsp�organizowania dzia�alno�ci urz�dniczej na rzecz otoczenia spo�ecznego administracji publicznej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K04", Opis = "jest got�w do inicjowania dzia�a� w�asnych i urz�dnik�w administracji publicznej na rzecz interesu publicznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K05", Opis = "jest got�w do my�lenia i dzia�ania w spos�b przedsi�biorczy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K06", Opis = "jest got�w do kultywowania i upowszechniania wzor�w w�a�ciwego post�powania w administracji publicznej oraz �rodowisku spo�ecznym, w szczeg�lno�ci: rozwijania dorobku zawodu, podtrzymywania etosu wykonywanego zawodu, przestrzegania i rozwijania zasad etyki zawodowej oraz dzia�ania na rzecz przestrzegania tych zasad", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K07", Opis = "jest got�w do samodzielnego podejmowania decyzji, krytycznej oceny dzia�a� w�asnych, dzia�a� zespo��w, kt�rymi kieruje, oraz kt�rych jest cz�onkiem, a tak�e przyjmowania odpowiedzialno�ci za skutki tych dzia�a�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "K_K08", Opis = "jest got�w do przewodzenia grupie i ponoszenia odpowiedzialno�ci za ni�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialAdmwPlocku.Id, Skrot = "U_K09", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzia� Bezpiecze�stwa narodowego w P�ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W01", Opis = "Posiada podstawow� wiedz� o naukach o bezpiecze�stwie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W02", Opis = "Posiada og�ln� wiedz� o dziedzinach nauk wspomagaj�cych nauki o bezpiecze�stwie takich jak: nauki spo�eczne, ekonomiczne i prawne oraz zachodz�cych mi�dzy nimi relacjami i wsp�zale�no�ciami", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W03", Opis = "Zna struktury systemu bezpiecze�stwa pa�stwa, uwarunkowania polityczno-prawne oraz zale�no�ci ekonomiczne w szczeg�lno�ci pomi�dzy podstawowymi elementami systemu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W04", Opis = "Ma podstawow� wiedz� o relacjach mi�dzy strukturami i instytucjami odpowiedzialnymi za bezpiecze�stwo narodowe na wszystkich poziomach jego organizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W05", Opis = "Ma elementarn� wiedz� o miejscu nauk o bezpiecze�stwie i wi�ziach z innymi dyscyplinami naukowymi w�a�ciwych dla studiowania relacji, prawid�owo�ci i powi�za� mi�dzy nimi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W06", Opis = "Posiada podstawow� wiedz� o koncepcjach, zasadach kszta�towania struktur spo�ecznych na rzecz szeroko poj�tego bezpiecze�stwa, a tak�e dzia�ania w tych strukturach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W07", Opis = "Zna metody i techniki pozyskiwania informacji pomi�dzy podsystemami wykonawczymi, a podsystemem kierowania i zarz�dzania bezpiecze�stwem", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W08", Opis = "Potrafi scharakteryzowa� i opisa� struktury zajmuj�ce si� bezpiecze�stwem w aspektach zewn�trznych i wewn�trznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W09", Opis = "Posiada uporz�dkowan� wiedz� o wybranych (dominuj�cych) podmiotach odpowiedzialnych za funkcjonowanie lokalnych system�w bezpiecze�stwa z uwzgl�dnieniem organizacji spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W10", Opis = "Zna i rozumie regu�y proceduralne normy organizacyjne instytucji spo�ecznych odpowiedzialnych za bezpiecze�stwo w tym sposoby dzia�ania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W11", Opis = "Ma pog��bion� wiedz� o procesach zmian wybranych struktur oraz instytucji odpowiedzialnych za zarz�dzanie bezpiecze�stwem", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W12", Opis = "Zna podstawowe elementy sk�adowe struktur zarz�dzaj�cych bezpiecze�stwem, a tak�e konsekwencje wynikaj�ce ze zmian przyczynowo-skutkowych i prawid�owo�ciach implikuj�cych te zmiany", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W13", Opis = "Ma ugruntowan� wiedz� na temat podstawowych struktur instytucji odpowiedzialnych za obronno�� w wymiarze narodowym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W14", Opis = "Zna rys historyczny z uwzgl�dnieniem edukacji strukturalnej i wp�ywu wi�zi spo�eczno-prawnych, praktycznych zastosowa� tych zmian wp�ywaj�cych na bezpiecze�stwo obywateli", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W15", Opis = "Posiada elementarn� wiedz� z zakresu ochrony w�asno�ci przemys�owej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W16", Opis = "Zna procedury zarz�dzania bezpiecze�stwem przemys�owym oraz logistyk� w sytuacjach kryzysowych z uwzgl�dnieniem czynnik�w formalno-prawnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_W17", Opis = "Zna og�lne zasady tworzenia i rozwoju form indywidualnej przedsi�biorczo�ci, wykorzystuj�cej wiedz� z zakresu dziedzin nauk spo�ecznych, ekonomicznych i prawnych oraz dyscyplin naukowych w�a�ciwych dla studiowanego kierunku studi�w tj: nauk o bezpiecze�stwie, obronno�ci, polityce, psychologii, socjologii, ekonomii, nauk o zarz�dzaniu, administracji i prawie", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "U_W18", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U01", Opis = "Potrafi prawid�owo interpretowa�, analizowa�, wyja�nia� zjawiska i zale�no�ci wyst�puj�ce pomi�dzy dziedzinami specyficznymi dla studiowanego kierunku studi�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U02", Opis = "Umie stosowa� w praktyce wiedz� teoretyczn� do szczeg�owego opisywania przyczynowo-skutkowego proces�w i procedur bezpiecze�stwa narodowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U03", Opis = "Potrafi formu�owa� i obiektywnie uzasadnia� w�asne opinie w oparciu o posiadane dane i wiedz�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U04", Opis = "Potrafi dokonywa� w�a�ciwej analizy procedur bezpiecze�stwa specyficznych dla dziedzin nauki i dyscyplin naukowych w�a�ciwych dla studiowanego kierunku studi�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U05", Opis = "Zna i potrafi wykorzysta� prognozy konkretnych zjawisk implikuj�cych stan bezpiecze�stwa", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U06", Opis = "Potrafi wykorzysta� w praktyce standardowe metody, narz�dzia i zasady wykorzystywane we w�a�ciwych dyscyplinach nauki wsp�graj�cych ze studiowanym kierunkiem studi�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U07", Opis = "Prawid�owo pos�uguje si� wybranymi systemami normatywnymi i umie je wykorzysta� w praktyce", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U08", Opis = "Zna podstawowe funkcje i regu�y kszta�tuj�ce istot� bezpiecze�stwa wynikaj�ce z konkretnego zadania praktycznego z zakresu zgrywania dziedzin nauki i dyscyplin naukowych w�a�ciwych dla studiowanego kierunku studi�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U09", Opis = "Posiada umiej�tno�� zgrywania wiedzy teoretycznej z umiej�tno�ciami praktycznymi nabytymi podczas praktyk zawodowych w celu realizacji z zada� z zakresu bezpiecze�stwa narodowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U10", Opis = "Trafnie analizuje zaistnia�e problemy, potrafi proponowa� konkretne rozwi�zania i rozstrzygni�cia sytuacji spornych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U11", Opis = "Posiada zdolno�� wdra�ania proponowanych rozwi�za�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U12", Opis = "Posiada umiej�tno�� rozumienia, diagnozowania i analizowania, a tak�e oceniania zjawisk w wybranych procedurach bezpiecze�stwa z uwypukleniem wskazanych dyscyplin naukowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U13", Opis = "Posiada umiej�tno�� opracowywania charakterystycznych prac pisemnych w j�zyku polskim i j�zyku obcym specyficznych dla dziedzin i dyscyplin nauki z obszaru nauk spo�ecznych sp�jnych ze studiowanym kierunkiem studi�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U14", Opis = "Ma zdolno�� w wyszukiwaniu poj�� i definicji w r�nych �r�d�ach oraz bieg�o�� w wykorzystywaniu ich do cel�w praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U15", Opis = "Posiada umiej�tno�� wykorzystania posiadanej wiedzy i jej ekspozycji w wyst�pieniach ustnych w j�zyku polskim i j�zyku obcym w dziedzinach i dyscyplinach nauki z obszaru nauk spo�ecznych sp�jnych ze studiowanym kierunkiem studi�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U16", Opis = "Ma zdolno�� oraz bieg�o�� w umiej�tnym wykorzystywaniu poj�� wraz z szczeg�ow� analiz� do cel�w praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_U17", Opis = "Ma umiej�tno�ci j�zykowe w zakresie dziedzin nauki i dyscyplin naukowych w�a�ciwych dla zakresu tematyczno-problemowego nauk o bezpiecze�stwie zgodne z wymaganiami okre�lonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta�cenia J�zykowego. Posiada odpowiedni� bieg�o�� w pos�ugiwaniu si� j�zykiem obcym niezb�dn� do wykonywania aktualnych zada�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "U_U18", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K01", Opis = "Rozumie potrzeb� uczenia si� przez ca�e �ycie", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K02", Opis = "Potrafi wsp�pracowa� i wsp�dzia�a� w grupie rozumiej�c znaczenie funkcji i relacji prze�o�ony i podw�adny", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K03", Opis = "Dostrzega znaczenie zmienno�ci funkcji w grupie, umie przyjmowa� r�ne role w jej strukturach", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K04", Opis = "Umie prawid�owo wyznacza� g��wne priorytety s�u��ce realizacji zada� grupowych i indywidualnych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K05", Opis = "Prawid�owo rozpoznaje wszelkie sk�adowe charakterystyczne dla wybranej specjalno�ci studi�w", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K06", Opis = "Potrafi rozstrzyga� i uzasadnia� wszelkie w�tpliwo�ci wynikaj�ce ze specyfiki zawodu i danego obszaru dzia�alno�ci", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K07", Opis = "Rozumie istot� i znaczenie projekt�w spo�ecznych w zakresie polepszania funkcjonuj�cego systemu bezpiecze�stwa", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K08", Opis = "Potrafi przewidywa� wszelkie uwarunkowania: polityczne, gospodarcze, obywatelskie wszelkich inicjatywach spo�ecznych w aspekcie bezpiecze�stwa narodowego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K09", Opis = "Aktywnie uczestniczy w powstawaniu projekt�w spo�ecznych uwydatniaj�c w nich elementy prawne, ekonomiczne i polityczne", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K10", Opis = "Potrafi samodzielnie uzupe�nia� posiadan� wiedz�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K11", Opis = "Rozumie znaczenie samoewaluacji i ci�g�ego doskonalenia posiadanych umiej�tno�ci", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "K_K12", Opis = "Potrafi gromadzi� i przetwarza� wszelkie informacje wykazuj�c si� przedsi�biorczo�ci� w dzia�aniu", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialBezpwPlocku.Id, Skrot = "U_K13", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzia� Informatyki w P�ocku
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W01", Opis = "ma wiedz� z zakresu matematyki i fizyki niezb�dn� do formu�owania i rozwi�zywania typowych, prostych zada� z zakresu informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W02", Opis = "ma podstawow� wiedz� w zakresie kierunk�w studi�w powi�zanych z informatyk�", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W03", Opis = "posiada wiedz� og�ln� z zakresu kluczowych zagadnie� informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W04", Opis = "ma szczeg�ow� wiedz� zwi�zan� z wybranymi zagadnieniami z informatyki: programowania, sieci komputerowych, teleinformatyki, baz danych, grafiki komputerowej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W05", Opis = "ma podstawow� wiedz� o cyklu �ycia system�w informatycznych i sieci teleinformatycznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W06", Opis = "zna podstawowe metody, techniki i narz�dzia stosowane przy rozwi�zywaniu prostych zada� in�ynierskich z zakresu informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W07", Opis = "ma podstawow� wiedz� w zakresie standard�w i norm technicznych wyst�puj�cych w informatyce", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W08", Opis = "ma podstawow� wiedz� niezb�dn� do rozumienia spo�ecznych, ekonomicznych i prawnych uwarunkowa� dzia�alno�ci in�yniera informatyka", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W09", Opis = "ma podstawow� wiedz� dotycz�c� zarz�dzania, w tym zarz�dzania jako�ci�, i prowadzenia dzia�alno�ci gospodarczej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W10", Opis = "zna i rozumie podstawowe poj�cia i zasady z zakresu ochrony w�asno�ci intelektualnej i prawa autorskiego w odniesieniu do produkt�w rynku informatycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_W11", Opis = "zna og�lne zasady tworzenia i rozwoju form indywidualnej przedsi�biorczo�ci w dziedzinie informatyki", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "U_W12", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U01", Opis = "potrafi pozyskiwa� informacje z literatury, baz danych oraz innych w�a�ciwie dobranych �r�de�, tak�e w j�zyku angielskim w zakresie informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U02", Opis = "potrafi integrowa� uzyskane informacje, dokonywa� ich interpretacji, a tak�e wyci�ga� wnioski oraz formu�owa� i uzasadnia� opinie w dziedzinie informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U03", Opis = "potrafi porozumiewa� si� przy u�yciu r�nych technik w �rodowisku zawodowym informatyk�w oraz w innych �rodowiskach, wykorzystuj�cych us�ugi informatyczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U04", Opis = "potrafi przygotowa� w j�zyku polskim i j�zyku angielskim, dobrze udokumentowane opracowanie problem�w z zakresu informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U05", Opis = "potrafi przygotowa� i przedstawi� w j�zyku polskim i j�zyku angielskim prezentacj� ustn�, dotycz�c� szczeg�owych zagadnie� z zakresu informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U06", Opis = "ma umiej�tno�� samokszta�cenia si�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U07", Opis = "ma umiej�tno�ci pos�ugiwania si� j�zykiem angielskim w zakresie informatyki, zgodne z wymaganiami okre�lonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta�cenia J�zykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U08", Opis = "potrafi pos�ugiwa� si� technikami informacyjno-komunikacyjnymi w�a�ciwymi do realizacji zada� typowych dla dzia�alno�ci in�ynierskiej w dziedzinie informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U09", Opis = "potrafi planowa� i przeprowadza� eksperymenty w dziedzinie informatyki, interpretowa� uzyskane wyniki i wyci�ga� wnioski", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U10", Opis = "potrafi wykorzysta� do formu�owania i rozwi�zywania zada� in�ynierskich metody analityczne, symulacyjne oraz eksperymentalne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U11", Opis = "potrafi � przy formu�owaniu i rozwi�zywaniu informatycznych zada� in�ynierskich - dostrzega� ich aspekty systemowe i pozatechniczne, w tym spo�eczne i kulturowe", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U12", Opis = "ma umiej�tno�ci niezb�dne do pracy w profesjonalnych �rodowiskach informatycznych oraz zna i stosuje zasady bezpiecze�stwa system�w komputerowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U13", Opis = "potrafi dokona� wst�pnej analizy ekonomicznej podejmowanych dzia�a� in�ynierskich w obszarze praktycznych zastosowa� informatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U14", Opis = "potrafi dokona� krytycznej analizy sposobu funkcjonowania system�w informatycznych i teleinformatycznych oraz oceni� istniej�ce rozwi�zania techniczne, w szczeg�lno�ci urz�dzenia sieciowe i komputerowe, systemy informatyczne, procesy oraz us�ugi z nimi zwi�zane", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U15", Opis = "potrafi dokona� identyfikacji i sformu�owa� specyfikacj� prostych informatycznych zada� in�ynierskich o charakterze praktycznym", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U16", Opis = "potrafi oceni� przydatno�� rutynowych metod i narz�dzi informatycznych s�u��cych do rozwi�zania prostego zadania in�ynierskiego o charakterze praktycznym oraz wybra� i zastosowa� w�a�ciw� metod� (procedur�) i narz�dzia informatyczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U17", Opis = "potrafi zaprojektowa� oraz zrealizowa� prosty system informatyczny lub struktur� sieci teleinformatycznej, u�ywaj�c w�a�ciwych metod, technik i narz�dzi", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U18", Opis = "ma do�wiadczenie zwi�zane z utrzymaniem system�w informatycznych lub sieci teleinformatycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U19", Opis = "ma do�wiadczenie zwi�zane z rozwi�zywaniem praktycznych zada� in�ynierskich, zdobyte w �rodowisku zajmuj�cym si� zawodowo dzia�alno�ci� in�yniersk� w obszarze informatyki lub teleinformatyki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_U20", Opis = "ma umiej�tno�� korzystania i do�wiadczenie w korzystaniu z norm i standard�w zwi�zanych z informatyka, a w szczeg�lno�ci metod: in�ynierii programowania, projektowania sieci teleinformatycznych oraz bezpiecze�stwa system�w komputerowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "U_U21", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K01", Opis = "rozumie potrzeb� uczenia si� przez ca�e �ycie poprzez pog��bianie wiedzy i umiej�tno�ci w dziedzinie informatyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K02", Opis = "ma �wiadomo�� wa�no�ci i rozumie spo�eczne i kulturowe aspekty i skutki dzia�alno�ci in�ynierskiej w dziedzinie zastosowa� informatyki; ma �wiadomo�� odpowiedzialno�ci za podejmowane decyzje w dziedzinie zastosowa� narz�dzi i metod informatycznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K03", Opis = "potrafi wsp�dzia�a� i pracowa� w grupie, przyjmuj�c w niej r�ne role w zakresie projektowania, budowy i wdro�e� system�w informatycznych i teleinformatycznych; potrafi przyjmowa� r�ne role w zespole: koordynatora, analityka, wykonawcy, itp..", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K04", Opis = "potrafi odpowiednio okre�li� priorytety s�u��ce realizacji okre�lonego przez siebie lub innych zadania informatycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K05", Opis = "prawid�owo identyfikuje i rozstrzyga dylematy zwi�zane z wykonywaniem zawodu informatyka", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K06", Opis = "potrafi my�le� i dzia�a� w spos�b przedsi�biorczy w dziedzinie zastosowa� informatyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "K_K07", Opis = "ma �wiadomo�� roli spo�ecznej informatyka, w szczeg�lno�ci rozumie potrzeb� formu�owania i przekazywania spo�ecze�stwu poprzez �rodki masowego przekazu, w spos�b komunikatywny informacji i opinii dotycz�cych osi�gni�� w dziedzinie informatyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istinz.Id, WydzialId = wydzialInfwPlocku.Id, Skrot = "U_K08", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzia� Pedagogiki w P�ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W01", Opis = "ma uporz�dkowan� wiedz� o r�nych �rodowiskach wychowawczych, ich specyfice i procesach w nich zachodz�cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W02", Opis = "w zaawansowanym stopniu zna teorie dotycz�ce wychowania, uczenia si� i nauczania, rozumie r�norodne uwarunkowania tych proces�w", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W03", Opis = "posiada w znacznym stopniu wiedz� o metodyce wykonywania typowych zada�, normach, procedurach stosowanych w r�nych obszarach dzia�alno�ci pedagogicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W04", Opis = "zna terminologi� u�ywan� w pedagogice i rozumie jej �r�d�a oraz zastosowania w obr�bie pokrewnych dyscyplin naukowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W05", Opis = "ma og�ln� wiedz� o projektowaniu i prowadzeniu bada� w pedagogice, a w szczeg�lno�ci o problemach badawczych, metodach, technikach i narz�dziach badawczych; zna podstawowe tradycje paradygmatyczne bada� spo�ecznych, z kt�rych wywodz� si� poszczeg�lne metody", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W06", Opis = "ma wiedz� o miejscu pedagogiki w systemie nauk oraz o jej przedmiotowych i metodologicznych powi�zaniach z innymi dyscyplinami naukowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W07", Opis = "zna koncepcje cz�owieka: filozoficzne, psychologiczne i spo�eczne stanowi�ce teoretyczne podstawy dzia�alno�ci pedagogicznej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W08", Opis = "ma wiedz� na temat rozwoju cz�owieka w cyklu �ycia zar�wno w aspekcie biologicznym, jak i psychologicznym oraz spo�ecznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W09", Opis = "posiada wiedz� o uczestnikach dzia�alno�ci edukacyjnej, wychowawczej, opieku�czej, kulturalnej i pomocowej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W10", Opis = "ma uporz�dkowan� wiedz� na temat wychowania i kszta�cenia, jego filozoficznych, spo�eczno-kulturowych, historycznych, biologicznych, psychologicznych i medycznych podstaw", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W11", Opis = "posiada wiedz� o rodzajach wi�zi spo�ecznych i o rz�dz�cych nimi prawid�owo�ciach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W12", Opis = "ma wiedz� o bezpiecze�stwie i higienie pracy w instytucjach edukacyjnych, wychowawczych, opieku�czych, kulturalnych i pomocowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W13", Opis = "ma wiedz� dotycz�c� proces�w komunikowania interpersonalnego i spo�ecznego, ich prawid�owo�ci i zak��ce�", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W14", Opis = "ma rozbudowan� wiedz� na temat projektowania �cie�ki w�asnego rozwoju", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W15", Opis = "ma uporz�dkowan� wiedz� na temat zasad i norm etycznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W16", Opis = "zna najwa�niejsze tradycyjne i wsp�czesne nurty i systemy pedagogiczne, rozumie ich historyczne i kulturowe uwarunkowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W17", Opis = "ma wiedz� o strukturze i funkcjach systemu edukacji; celach, podstawach prawnych, organizacji i funkcjonowaniu r�nych instytucji edukacyjnych, wychowawczych, opieku�czych, terapeutycznych, kulturalnych i pomocowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_W18", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U01", Opis = "potrafi innowacyjnie planowa� i realizowa� zadania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U02", Opis = "potrafi oceni� przydatno�� typowych �r�de�, metod, procedur i dobrych praktyk do realizacji zada� zwi�zanych z r�nymi sferami dzia�alno�ci pedagogicznej z wykorzystaniem ICT", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U03", Opis = "potrafi wykorzystywa� wiedz� teoretyczn� z zakresu pedagogiki oraz powi�zanych z ni� dyscyplin w celu analizowania i interpretowania problem�w edukacyjnych, wychowawczych, opieku�czych, kulturalnych i pomocowych, a tak�e motyw�w i wzor�w ludzkich zachowa�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U04", Opis = "potrafi prowadzi� podstawowe badania, dokona� obserwacji i interpretacji zjawisk spo�ecznych; analizuje ich powi�zania z r�nymi obszarami dzia�alno�ci pedagogicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U05", Opis = "potrafi pos�ugiwa� si� uj�ciami teoretycznymi w celu analizowania, interpretowania oraz projektowania strategii dzia�a� pedagogicznych; potrafi generowa� rozwi�zania konkretnych problem�w pedagogicznych i prognozowa� przebieg ich rozwi�zywania oraz przewidywa� skutki planowanych dzia�a�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U06", Opis = "potrafi prawid�owo pos�ugiwa� si� zasadami i normami etycznymi w podejmowanej dzia�alno�ci, dostrzega i analizuje dylematy etyczne; przewiduje skutki konkretnych dzia�a� pedagogicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U07", Opis = "ma rozwini�te umiej�tno�ci w zakresie komunikacji interpersonalnej, potrafi u�ywa� j�zyka specjalistycznego i porozumiewa� si� w spos�b precyzyjny i sp�jny przy u�yciu r�nych kana��w i technik komunikacyjnych ze specjalistami w zakresie pedagogiki, jak i z odbiorcami spoza grona specjalist�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U08", Opis = "posiada umiej�tno�� prezentowania w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je argumentacj� w kontek�cie wybranych perspektyw teoretycznych, pogl�d�w r�nych autor�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U09", Opis = "pos�ugiwa� si� j�zykiem obcym na poziomie B2 Europejskiego Systemu Opisu Kszta�cenia J�zykowego w obszarze pedagogiki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U10", Opis = "potrafi animowa� prace nad rozwojem uczestnik�w proces�w pedagogicznych oraz wspiera� ich samodzielno�� w zdobywaniu wiedzy, a tak�e inspirowa� do dzia�a� na rzecz uczenia si� przez ca�e �ycie oraz potrafi pracowa� w zespole pe�ni�c r�ne role", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U11", Opis = "potrafi samodzielnie zdobywa� wiedz�, dokona� analizy w�asnych dzia�a� i wskaza� ewentualne obszary wymagaj�ce modyfikacji w przysz�ym dzia�aniu i rozwija� swoje profesjonalne umiej�tno�ci, korzystaj�c z r�nych �r�de� (w j�zyku rodzimym i obcym) i nowoczesnych technologii (ICT)", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_U12", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K01", Opis = "ma przekonanie o wadze zachowania si� w spos�b profesjonalny, refleksji na tematy etyczne i przestrzegania zasad etyki zawodowej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K02", Opis = "jest przygotowany do aktywnego uczestnictwa w grupach, organizacjach i instytucjach realizuj�cych dzia�ania pedagogiczne i zdolny do porozumiewania si� z osobami b�d�cymi i nieb�d�cymi specjalistami w danej dziedzinie oraz przyjmowania odpowiedzialno�ci ich dzia�a�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K03", Opis = "potrafi kompetentnie oceni� posiadan� wiedz� i braki w tym zakresie", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K04", Opis = "rozumie potrzeb� ci�g�ego dokszta�cania si� zawodowego i rozwoju osobistego, wyznacza kierunki w�asnego rozwoju i kszta�cenia", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K05", Opis = "ma przekonanie o sensie, warto�ci i potrzebie inicjowania oraz podejmowania dzia�a� pedagogicznych w �rodowisku spo�ecznym; jest gotowy do podejmowania wyzwa� zawodowych; wykazuje aktywno��, podejmuje trud i odznacza si� wytrwa�o�ci� w realizacji indywidualnych i zespo�owych dzia�a� profesjonalnych w zakresie pedagogiki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K06", Opis = "dostrzega i formu�uje problemy moralne i dylematy etyczne zwi�zane z w�asn� i cudz� prac�, poszukuje optymalnych rozwi�za�, post�puje zgodnie z zasadami etyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K07", Opis = "jest �wiadomy istnienia etycznego wymiaru w badaniach naukowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K08", Opis = "odpowiedzialnie przygotowuje si� do swojej pracy, projektuje i wykonuje dzia�ania pedagogiczne wykorzystuj�c my�lenie i dzia�anie w spos�b efektywny i przedsi�biorczy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K09", Opis = "docenia znaczenie kultury dla utrzymania i rozwoju prawid�owych wi�zi w �rodowiskach spo�ecznych i odnosi zdobyt� wiedz� do projektowania dzia�a� zawodowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_K10", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W01", Opis = "posiada zaawansowan� i uporz�dkowan� wiedz� og�ln� i szczeg�ow� w zakresie pedagogiki i jej subdyscyplin obejmuj�c� fakty i zjawiska oraz metody i teorie pedagogiczne, a tak�e zale�no�ci mi�dzy nimi (zna terminologi�, teori� i metodyk�)", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W02", Opis = "ma pog��bion� i uporz�dkowan� wiedz� o wsp�czesnych kierunkach rozwoju pedagogiki, jej nurtach i systemach pedagogicznych, rozumie ich historyczne i kulturowe uwarunkowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W03", Opis = "ma uporz�dkowan� wiedz� na temat teorii wychowania, uczenia si� i nauczania oraz innych proces�w edukacyjnych oraz kierunkach rozwoju", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W04", Opis = "posiada pog��bion� wiedz� z zakresu metodologii bada� stosowanych w naukach spo�ecznych i humanistycznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W05", Opis = "ma rozszerzon� wiedz� o �r�d�ach, miejscu i znaczeniu pedagogiki w systemie nauk oraz o jej przedmiotowych i metodologicznych powi�zaniach z innymi dyscyplinami nauk", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W06", Opis = "ma pog��bion� wiedz� na temat rozwoju cz�owieka w cyklu �ycia zar�wno w aspekcie biologicznym, psychologicznym jak i spo�ecznym oraz o rodzajach wi�zi spo�ecznych i rz�dz�cych nimi prawid�owo�ciach z punktu widzenia proces�w kulturowych i edukacyjnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W07", Opis = "zna i rozumie jakie jest praktyczne wykorzystanie wiedzy z zakresu nauk humanistycznych i spo�ecznych w dzia�alno�ci edukacyjnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W08", Opis = "posiada zaawansowan� wiedz� o metodach analizy i interpretacji kulturowych uwarunkowa� proces�w edukacyjnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W09", Opis = "ma wiedz� dotycz�c� zagro�e� wsp�czesnej cywilizacji i ich wp�ywu na wychowanie i procesy edukacyjne", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W10", Opis = "ma uporz�dkowan� wiedz� o ekonomicznych, prawnych i etycznych uwarunkowaniach zwi�zanych z edukacj�, w tym przepis�w dotycz�cych ochrony w�asno�ci intelektualnej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W11", Opis = "posiada wiedz� dotycz�c� zarz�dzania zasobami w�asno�ci intelektualnej oraz zna formy i zasady prowadzenia indywidualnej dzia�alno�ci gospodarczej oraz �r�d�a przepis�w i rozwi�za� prawnych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_W12", Opis = "ma uporz�dkowan� wiedz� o celach, strukturze i zasadach funkcjonowania system�w oraz instytucji edukacyjnych, wychowawczych, opieku�czych, terapeutycznych, kulturalnych, rewaliduj�cych i resocjalizuj�cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_W13", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywa� i integrowa� wiedz� teoretyczn� z zakresu pedagogiki oraz powi�zanych z ni� dyscyplin w celu analizy z�o�onych problem�w edukacyjnych, wychowawczych, opieku�czych, kulturalnych, pomocowych i terapeutycznych, a tak�e diagnozowania i projektowania rozwi�za� i dzia�a� praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U02", Opis = "potrafi tw�rczo animowa� prace nad w�asnym rozwojem oraz rozwojem uczestnik�w proces�w edukacyjno-wychowawczych oraz wspiera� ich samodzielno�� w zdobywaniu wiedzy a tak�e inspirowa� do dzia�a� na rzecz uczenia si� przez ca�e �ycie", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U03", Opis = "potrafi, w oparciu o posiadan� wiedz� i umiej�tno�ci oraz dob�r w�a�ciwych technik, metod i narz�dzi komunikacyjnych porozumiewa� si� z szerokim gronem odbiorc�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U04", Opis = "potrafi w spos�b sp�jny i precyzyjny prezentowa� w�asne stanowisko uzasadnione rozbudowan� argumentacj�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U05", Opis = "potrafi dokona� analizy i oceny problem�w pedagogicznych i generowa� oryginalne ich rozwi�zania oraz prognozowa� przebieg oraz przewidywa� skutki planowanych dzia�a� w okre�lonych obszarach praktycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U06", Opis = "potrafi wybra� i zastosowa� w�a�ciwy dla danej dzia�alno�ci spos�b post�powania, dobra� odpowiednie metody, �rodki i techniki (w tym zaawansowane techniki informacyjno-komunikacyjne) w celu efektywnej realizacji zada� zawodowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U07", Opis = "posiada pog��bione umiej�tno�ci identyfikowania i interpretowania zjawisk oraz proces�w spo�ecznych, a tak�e dostrzegania relacji mi�dzy nimi z punktu widzenia problem�w edukacyjnych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U08", Opis = "potrafi pos�ugiwa� si� systemami normatywnymi w celu rozwi�zywania problem�w edukacyjnych, wychowawczych, opieku�czych, terapeutycznych, pomocowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U09", Opis = "potrafi analizowa�, prognozowa� i modelowa� z�o�one procesy spo�eczne z wykorzystaniem zaawansowanych metod i narz�dzi stosowanych w naukach spo�ecznych i humanistycznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U10", Opis = "posiada rozwini�te umiej�tno�ci badawcze: rozr�nia orientacje w metodologii bada� pedagogicznych, formu�uje problemy badawcze, dobiera adekwatne metody, techniki i konstruuje narz�dzia badawcze", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U11", Opis = "opracowuje, prezentuje i interpretuje wyniki bada�, wyci�ga wnioski, wskazuje kierunki dalszych bada�, w obr�bie wybranej subdyscypliny pedagogiki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U12", Opis = "potrafi w spos�b precyzyjny wypowiada� si� w mowie i pi�mie na tematy dotycz�ce r�nych zagadnie� pedagogicznych z wykorzystaniem r�nych uj�� teoretycznych, korzystaj�c zar�wno z dorobku pedagogiki, jak i innych dyscyplin naukowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U13", Opis = "posiada umiej�tno�ci j�zykowe w�a�ciwe dla kierunku pedagogika, zgodne z wymogami okre�lonymi dla poziomu B2+ Europejskiego Systemu Opisu Kszta�cenia J�zykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U14", Opis = "potrafi pracowa� w zespole przyjmuj�c rol� lidera w celu efektywnego wykonania zada� zawodowych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_U15", Opis = "rozumie potrzeb� ustawicznego samorozwoju i potrafi podj�� dzia�ania nad w�asnym rozwojem oraz rozwojem uczestnik�w proces�w edukacyjno-wychowawczych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_U16", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K01", Opis = "potrafi okre�li� warto�ci, cele i zadania realizowane w praktyce pedagogicznej i zachowa� si� w spos�b profesjonalny przy jednoczesnym przestrzeganiu zasad etyki zawodowej", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K02", Opis = "dostrzega i formu�uje problemy moralne i dylematy etyczne zwi�zane z w�asn� i cudz� prac�, poszukuje optymalnych rozwi�za� i mo�liwo�ci korygowania nieprawid�owych dzia�a� pedagogicznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K03", Opis = "potrafi pracowa� w zespole, a tak�e pe�ni� rol� lidera", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K04", Opis = "odznacza si� rozwag� i dojrza�o�ci� w odbiorze tre�ci oraz rozumie konieczno�� ich w�a�ciwego doboru", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K05", Opis = "pos�uguje si� wiedz� praktyczn� w celu definiowania i analizy podejmowanych dzia�a� praktycznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K06", Opis = "jest przekonany o sensie, warto�ci i potrzebie podejmowania dzia�a� w �rodowisku spo�ecznym; jest gotowy do podejmowania wyzwa� zawodowych; wykazuje aktywno��, podejmuje trud i odznacza si� wytrwa�o�ci� w realizacji indywidualnych i zespo�owych zada� zawodowych wynikaj�cych z roli pedagoga", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K07", Opis = "jest gotowy do inicjowania i podejmowania indywidualnych i zespo�owych dzia�a� na rzecz podnoszenia jako�ci pracy szko�y lub innych instytucji edukacyjnych, opieku�czych i wychowawczych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K08", Opis = "jest gotowy do podejmowania wyzwa� zawodowych i osobistych; rozumie istot� i potrzeb� przedsi�biorczej postawy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K09", Opis = "docenia znaczenie nauk pedagogicznych dla rozwoju jednostki i prawid�owych wi�zi w �rodowiskach spo�ecznych, ma pozytywne nastawienie do nabywania wiedzy z zakresu studiowanej dyscypliny naukowej i budowania warsztatu pracy pedagoga", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K10", Opis = "Jest przekonany o konieczno�ci i donios�o�ci zachowania si� w spos�b profesjonalny i przestrzegania zasad etyki zawodowej; dostrzega i formu�uje problemy moralne i dylematy etyczne zwi�zane z w�asn� i cudz� prac�; poszukuje optymalnych rozwi�za� i mo�liwo�ci korygowania nieprawid�owych dzia�a� pedagogicznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "K_K11", Opis = "Jest gotowy do uczestniczenia w �yciu kulturalnym i korzystania z jego r�norodnych form i dorobku w celu rozwijania w�asnych kompetencji pedagogicznych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialPedwPlocku.Id, Skrot = "U_K12", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //Wydzial WF w P�ocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W01", Opis = "posiada podstawow� wiedz� w zakresie fizykochemicznych i biologicznych podstaw wychowania fizycznego oraz zdrowotnego dzieci i m�odzie�y", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W02", Opis = "posiada podstawow� wiedz� o budowie oraz funkcjach organizmu cz�owieka, a szczeg�lnie o funkcjonowaniu organizmu podczas wysi�ku fizycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W03", Opis = "zna podstawowe metody oceny zdolno�ci wysi�kowych, kondycyjnych i koordynacyjnych cz�owieka, metody oceny stanu rozwoju fizycznego dzieci i m�odzie�y oraz czynniki determinuj�ce ten rozw�j", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W04", Opis = "zna podstawowe poj�cia i mechanizmy psychospo�eczne zwi�zane ze zdrowiem oraz ochron� zdrowia i sprawno�ci psychofizycznej cz�owieka", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W05", Opis = "zna teoretyczne podstawy dzia�a� interwencyjnych wobec jednostek oraz grup spo�ecznych w zakresie udzielania pierwszej pomocy, przeciwdzia�ania agresji fizycznej oraz zapobiegania patologiom spo�ecznym wyst�puj�cym w�r�d dzieci i m�odzie�y", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W06", Opis = "zna zasady promocji zdrowia i zdrowego trybu (stylu) �ycia ze szczeg�lnym uwzgl�dnieniem aktywno�ci fizycznej, rekreacji i sportu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W07", Opis = "zna skutki r�nych form aktywno�ci ruchowej i jej braku, rozumie procesy adaptacji organizmu do r�nych form wysi�ku fizycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W08", Opis = "zna prawne, organizacyjne i etyczne uwarunkowania wykonywania dzia�alno�ci zawodowej nauczyciela wychowania fizycznego i dydaktyka sportu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W09", Opis = "zna miejsce dziedziny nauk o kulturze fizycznej, znaczenie i miejsce wychowania fizycznego i zdrowotnego w ramach krajowego systemu ochrony zdrowia", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W10", Opis = "ma podstawow� wiedz� i zna terminologi� nauk o kulturze fizycznej w zakresie niezb�dnym do wykonywania zawodu nauczyciela wychowania fizycznego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W11", Opis = "zna i rozumie podstawowe poj�cia i zasady z zakresu ochrony w�asno�ci przemys�owej i prawa autorskiego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_W12", Opis = "zna og�lne zasady tworzenia i rozwoju form indywidualnej przedsi�biorczo�ci, wykorzystuj�cej wiedz� z zakresu kultury fizycznej, a w szczeg�lno�ci z zakresu wychowania fizycznego i zdrowotnego, rekreacji oraz sportu", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "U_W13", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U01", Opis = "posiada niezb�dne umiej�tno�ci w zakresie zapewnienia bezpiecze�stwa uczni�w, udzielania pierwszej pomocy przedmedycznej, oceny jako�ci �rodowiska zaj��, u�ywanych urz�dze� sportowych, sprz�tu i przybor�w, w zakresie ich przechowywania i podstawowych zasad konserwacji", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U02", Opis = "potrafi pos�ugiwa� si� podstawowym sprz�tem, przyborami, urz�dzeniami stosowanymi w wychowaniu fizycznym i sporcie, potrafi korzysta� z dost�pnej bazy sportowej i rekreacyjnej, jak sale do �wicze� fizycznych, boiska, baseny itp.", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U03", Opis = "potrafi komunikowa� si� z jednostk� oraz grup� spo�eczn� w zakresie zwi�zanym z wychowaniem fizycznym, zdrowotnym, sportem i rekreacj� fizyczn�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U04", Opis = "potrafi identyfikowa� indywidualne oraz grupowe problemy uczni�w w zakresie kultury fizycznej, wychowania fizycznego, zdrowotnego i rekreacji fizycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U05", Opis = "potrafi podj�� dzia�ania diagnostyczne, profilaktyczne, piel�gnacyjne, terapeutyczne i edukacyjne odpowiadaj�ce potrzebom jednostki oraz grupy spo�ecznej w�a�ciwe dla wychowania fizycznego i r�nych form fizycznej rekreacji", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U06", Opis = "potrafi korzysta� z technik informacyjnych w celu pozyskiwania i przechowywania danych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U07", Opis = "potrafi identyfikowa� b��dy i zaniedbania w praktyce dydaktycznej zwi�zanej z wykonywaniem zawodu nauczyciela wychowania fizycznego i zdrowotnego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U08", Opis = "potrafi interpretowa� dane liczbowe zwi�zane z zawodem nauczyciela wychowania fizycznego dotycz�ce wynik�w pomiar�w antropometrycznych, wynik�w pr�b (test�w) sprawno�ci fizycznej oraz dane zwi�zane z r�nymi charakterystykami i efektami wysi�ku fizycznego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U09", Opis = "potrafi prowadzi� dokumentacj� dotycz�c� planowania, realizacji i oceny efekt�w pracy dydaktyczno-wychowawczej nauczyciela wychowania fizycznego w wymiarze indywidualnym, grupowym oraz instytucjonalnym", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U10", Opis = "potrafi planowa�, projektowa� i realizowa� dzia�ania z zakresu wychowania fizycznego i zdrowotnego oraz rekreacji fizycznej z uwzgl�dnieniem obowi�zuj�cych norm oraz dost�pnych warunk�w", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U11", Opis = "posiada umiej�tno�ci ruchowe z zakresu utylitarnych form ruchu (p�ywanie z elementami ratownictwa wodnego, bezpieczne upadanie i podstawowe umiej�tno�ci samoobrony, jazda na rowerze, na nartach, lekkoatletyka, p�ywanie na kajaku itp.) oraz umiej�tno�ci ruchowe i sprawno�� motoryczn� zapewniaj�ce realizacj� hedonistycznych oraz ludycznych potrzeb cz�owieka (gry i zabawy ruchowe, zespo�owe gry sportowe, ta�ce oraz nowoczesne formy gimnastyczno-taneczne itp.)", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U12", Opis = "posiada umiej�tno�� przygotowania pisemnego raportu w oparciu o w�asne dzia�ania lub dane �r�d�owe", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U13", Opis = "posiada umiej�tno�� prezentowania w formie ustnej wynik�w w�asnych dzia�a� i przemy�le�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_U14", Opis = "ma umiej�tno�ci j�zykowe w zakresie wychowania fizycznego, rekreacji i sportu, zgodne z wymaganiami okre�lonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta�cenia J�zykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "U_U15", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K01", Opis = "rozumie potrzeb� uczenia si� przez ca�e �ycie, potrzeb� pog��biania w�asnej wiedzy oraz umiej�tno�ci zawodowych, d��y do rozwoju warsztatu pracy nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K02", Opis = "posiada �wiadomo�� w�asnych ogranicze� i wie, kiedy zwr�ci� si� do ekspert�w", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K03", Opis = "okazuje szacunek wobec uczni�w i innych os�b, wobec grup spo�ecznych, troszczy si� o ich dobro i dobro wsp�lne", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K04", Opis = "potrafi wsp�dzia�a� i pracowa� w grupie, przyjmuj�c w niej r�ne role", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K05", Opis = "potrafi odpowiednio okre�li� priorytety s�u��ce realizacji okre�lonego przez siebie lub innych zadania w zakresie kultury fizycznej i wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K06", Opis = "potrafi rozwi�zywa� najcz�stsze problemy zwi�zane z wykonywaniem zawodu nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K07", Opis = "realizuje zadania w spos�b zapewniaj�cy bezpiecze�stwo w�asne i otoczenia, w tym przestrzega zasad bezpiecze�stwa pracy", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K08", Opis = "potrafi formu�owa� opinie dotycz�ce indywidualnych uczni�w i grup uczni�w, a tak�e grup spo�ecznych w kontek�cie zwi�zanym z wykonywaniem zawodu nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "K_K09", Opis = "dba o wizerunek w�asnej osoby i poziom sprawno�ci fizycznej niezb�dnej dla wykonywania zada� zwi�zanych z zawodem nauczyciela wychowania fizycznego", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialWfwPlocku.Id, Skrot = "U_K10", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                //wydzial zrzazdania w plocku
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W01", Opis = "ma elementarn� wiedz� o miejscu zarz�dzania w systemie nauk oraz jej powi�zaniach z innymi dyscyplinami naukowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W02", Opis = "zna elementarn� terminologi� stosowan� w zarz�dzaniu i rozumie jej �r�d�a oraz relacje do terminologii z pokrewnych dyscyplin naukowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W03", Opis = "rozumie zasady, prawid�owo�ci i instrumenty zarz�dzania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W04", Opis = "posiada elementarn� wiedz� o podstawowych elementach r�nych rodzaj�w struktur spo�ecznych i instytucji �ycia spo�ecznego i gospodarczego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W05", Opis = "rozumie istot� i mechanizmy funkcjonowania organizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W06", Opis = "ma elementarn� wiedz� o r�nych rodzajach struktur spo�ecznych i instytucjach �ycia spo�ecznego oraz zachodz�cych mi�dzy nimi relacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W07", Opis = "posiada systemow� wiedz� o r�nych organizacjach spo�eczno-ekonomicznych, ich specyfice i wzajemnych uwarunkowaniach ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W08", Opis = "ma podstawow� wiedz� o na temat funkcjonowania cz�owieka w organizacjach, zar�wno w aspekcie socjologicznym, jak i psychologicznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W09", Opis = "ma podstawow� wiedz� o rodzajach wi�zi spo�ecznych i rz�dz�cych nimi prawid�owo�ciach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W10", Opis = "ma podstawow� wiedz� o uczestnikach dzia�alno�ci gospodarczej w skali mikro jak i makro", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W11", Opis = "ma podstawow� wiedz� na temat cz�owieka, zar�wno w aspekcie socjologicznym, jak i psychologicznym oraz o specyfice jego funkcjonowania w organizacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W12", Opis = "ma elementarn� wiedz� o projektowaniu i prowadzeniu bada� z zakresu zarz�dzania, a w szczeg�lno�ci o problemach badawczych, metodach, technikach i narz�dziach badawczych; zna podstawowe zasady i metody bada� spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W13", Opis = "ma uporz�dkowan� wiedz� na temat zasad i norm etycznych i spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W14", Opis = "ma elementarn� wiedz� o bezpiecze�stwie i higienie pracy w organizacjach oraz wiedz� na temat bezpiecze�stwa publicznego oraz zapobiegania i zarz�dzania sytuacjami kryzysowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W15", Opis = "ma podstawow�, uporz�dkowan� wiedz� na temat zasad zarz�dzania zmianami w organizacjach, przyczyn, proces�w i wynikaj�cych z nich skutk�w", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W16", Opis = "ma podstawow� wiedz� o wsp�czesnych pogl�dach oraz ich ewolucji, na temat wybranych struktur organizacji, instytucji i podmiot�w gospodarczych oraz wi�zi spo�ecznych w nich funkcjonuj�cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W17", Opis = "ma podstawow� wiedz� na temat praw autorskich, prawa wynalazczego i patentowego i rozumie zasady ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W18", Opis = "rozumie poj�cie przedsi�biorczo�ci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W19", Opis = "ma podstawow� wiedz� na temat tworzenia i rozwoju form przedsi�biorczo�ci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_W20", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywa� podstawow� wiedz� teoretyczn� z zakresu zarz�dzania oraz powi�zanych z ni� dyscyplin w celu interpretowania zjawisk i problem�w spo�ecznych i ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U02", Opis = "potrafi wykorzystywa� podstawow� wiedz� teoretyczn� z zakresu zarz�dzania oraz powi�zanych z ni� dyscyplin w celu opisywania i praktycznego analizowania jednostkowych proces�w i zjawisk spo�eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U03", Opis = "posiada elementarne umiej�tno�ci badawcze pozwalaj�ce na analizowanie przyk�ad�w bada� oraz konstruowanie i prowadzenie prostych bada� empirycznych, potrafi opracowa� i zaprezentowa� ich wyniki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U04", Opis = "potrafi w�a�ciwie analizowa� przyczyny i przebieg wybranych proces�w i zjawisk spo�eczno-ekonomicznych w obszarze zarz�dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U05", Opis = "potrafi pos�ugiwa� si� podstawowymi uj�ciami teoretycznymi w celu analizowania motyw�w i wzor�w ludzkich zachowa�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U06", Opis = "potrafi wykorzysta� standardowe metody i narz�dzia badawcze w celu prognozowania praktycznych skutk�w proces�w i zjawisk spo�eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U07", Opis = "potrafi generowa� rozwi�zania konkretnych problem�w gospodarczych i prognozowa� przebieg ich rozwi�zywania oraz przewidywa� skutki planowanych dzia�a�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U08", Opis = "potrafi pos�ugiwa� si� wybranymi regu�ami prawnymi w rozwi�zywaniu konkretnych zada� z zakresu zarz�dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U09", Opis = "potrafi pos�ugiwa� si� regu�ami zawodowymi i normami etycznymi oraz dostrzega i analizuje dylematy etyczne w prowadzonej dzia�alno�ci", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U10", Opis = "potrafi powi�za� posiadan� wiedz� teoretyczn� z zakresu zarz�dzania z praktycznymi umiej�tno�ciami i do�wiadczeniami nabytymi podczas praktyki zawodowej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U11", Opis = "potrafi inspirowa� procesy gospodarcze, animowa� prace nad rozwojem uczestnik�w proces�w zarz�dzania oraz wspiera� ich samodzielno�� w zdobywaniu wiedzy", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U12", Opis = "potrafi oceni� przydatno�� typowych metod, procedur i odpowiednich praktyk do realizacji zada� zwi�zanych z r�nymi sferami dzia�alno�ci spo�eczno-ekonomicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U13", Opis = "posiada umiej�tno�� prezentowania w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je w�a�ciw� argumentacj�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U14", Opis = "potrafi dokona� obserwacji zjawisk spo�ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U15", Opis = "potrafi w�a�ciwie analizowa� i interpretowa� zaobserwowane zjawiska spo�eczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U16", Opis = "posiada umiej�tno�� sporz�dzania prac pisemnych w j�zyku polskim i wybranym j�zyku obcym, traktuj�cych o wybranych zagadnieniach szczeg�owych z zakresu zarz�dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U17", Opis = "posiada umiej�tno�� prezentowania w formie pisemnej w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je argumentacj� w kontek�cie wybranych uj�� teoretycznych z wykorzystaniem r�nych �r�de�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U18", Opis = "posiada umiej�tno�� swobodnej wypowiedzi w j�zyku polskim i wybranym j�zyku obcym, traktuj�cych o wybranych zagadnieniach szczeg�owych z zakresu zarz�dzania, wi���c je z dyscyplinami pokrewnymi", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U19", Opis = "posiada umiej�tno�� prezentowania w formie ustnej w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je argumentacj� w kontek�cie wybranych uj�� teoretycznych z wykorzystaniem r�nych �r�de�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U20", Opis = "posiada umiej�tno�� swobodnej wypowiedzi w mowie i pi�mie w zakresie zarz�dzania, zgodnie z wymaganiami okre�lonymi dla poziomu B2 Europejskiego Systemu Opisu Kszta�cenia J�zykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_U21", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K01", Opis = "ma �wiadomo�� poziomu swojej wiedzy i umiej�tno�ci, rozumie potrzeb� sta�ego dokszta�cania zawodowego i rozwoju osobistego, dokonuje samooceny w�asnych kompetencji i doskonali umiej�tno�ci, wyznacza kierunki w�asnego rozwoju i samokszta�cenia", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K02", Opis = "potrafi dokona� analizy w�asnych dzia�a� i wskaza� ewentualne obszary wymagaj�ce modyfikacji w przysz�ym dzia�aniu", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K03", Opis = "jest przygotowany do aktywnego uczestnictwa i pracy w zespo�ach zadaniowych, organizacjach i instytucjach realizuj�cych dzia�ania gospodarcze", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K04", Opis = "potrafi si� elastycznie dostosowa� do pe�nienia r�nych funkcji w zespo�ach zadaniowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K05", Opis = "jest przygotowany do kierowania zespo�ami zadaniowymi", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K06", Opis = "jest �wiadomy hierarchii i stratyfikacji priorytet�w i jest w stanie dokonywa� optymalnego wyboru priorytet�w przy planowaniu zada� dla siebie oraz dla innych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K07", Opis = "ma przekonanie o wadze zachowania si� w spos�b profesjonalny, przestrzegania zasad etyki menad�erskiej oraz spo�ecznej odpowiedzialno�ci organizacji", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K08", Opis = "dostrzega i formu�uje problemy moralne i dylematy etyczne zwi�zane z w�asn� i cudz� prac�, poszukuje optymalnych rozwi�za�, post�puje zgodnie z zasadami etyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K09", Opis = "odpowiedzialnie przygotowuje si� do swojej pracy, projektuje i wykonuje dzia�ania w obszarze zarz�dzania posi�kuj�c si� analiz� systemow� i wielokryterialn�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K10", Opis = "ma �wiadomo�� zasad i nowoczesnych instrument�w zarz�dzania projektami", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K11", Opis = "ma przekonanie o potrzebie ci�g�ego uzupe�niania i doskonalenia w�asnej wiedzy i umiej�tno�ci, jest w stanie w�a�ciwie zidentyfikowa� jej �r�d�a i zakres", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K12", Opis = "ma przekonanie o sensie, warto�ci i potrzebie podejmowania dzia�a� gospodarczych w �rodowisku spo�ecznym; jest gotowy do podejmowania wyzwa� zawodowych; wykazuje aktywno��, podejmuje trud i odznacza si� wytrwa�o�ci� w realizacji indywidualnych i zespo�owych dzia�a� profesjonalnych w zakresie zarz�dzania, uwzgl�dniaj�c teoretyczne i praktyczne przes�anki zarz�dzania ryzykiem", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = Istlic.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_K13", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id },

                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W01", Opis = "ma rozszerzon� wiedz� o miejscu zarz�dzania w systemie nauk oraz jej powi�zaniach z innymi dyscyplinami naukowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W02", Opis = "zna poszerzon� terminologi� stosowan� w zarz�dzaniu i rozumie jej �r�d�a oraz relacje do terminologii z pokrewnych dyscyplin naukowych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W03", Opis = "rozumie zasady, prawid�owo�ci i instrumenty zarz�dzania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W04", Opis = "posiada rozszerzon� wiedz� o podstawowych elementach r�nych rodzaj�w struktur spo�ecznych i instytucji �ycia spo�ecznego i gospodarczego", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W05", Opis = "rozumie istot� i mechanizmy funkcjonowania organizacji", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W06", Opis = "ma pog��bion� wiedz� o r�nych rodzajach struktur spo�ecznych i instytucjach �ycia spo�ecznego oraz zachodz�cych mi�dzy nimi relacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W07", Opis = "posiada systemow� wiedz� o r�nych organizacjach spo�eczno-ekonomicznych, ich specyfice i wzajemnych uwarunkowaniach ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W08", Opis = "ma rozszerzon� wiedz� o na temat funkcjonowania cz�owieka w organizacjach, zar�wno w aspekcie socjologicznym, jak i psychologicznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W09", Opis = "ma rozszerzon� wiedz� o rodzajach wi�zi spo�ecznych i rz�dz�cych nimi prawid�owo�ciach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W10", Opis = "ma rozszerzon� wiedz� o uczestnikach dzia�alno�ci gospodarczej w skali mikro jak i makro", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W11", Opis = "ma wiedz� na temat cz�owieka, zar�wno w aspekcie socjologicznym, jak i psychologicznym", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W12", Opis = "ma pog��bion� wiedz� o specyfice funkcjonowania cz�owieka w organizacjach", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W13", Opis = "ma pog��bion� wiedz� o projektowaniu i prowadzeniu bada� z zakresu zarz�dzania, a w szczeg�lno�ci o problemach badawczych, metodach, technikach i narz�dziach badawczych; zna podstawowe zasady i metody bada� spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W14", Opis = "ma uporz�dkowan� wiedz� na temat zasad i norm etycznych i spo�ecznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W15", Opis = "ma pog��bion� wiedz� o bezpiecze�stwie i higienie pracy w organizacjach, wiedz� na temat bezpiecze�stwa publicznego oraz zapobiegania i zarz�dzania sytuacjami kryzysowymi", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W16", Opis = "ma pog��bion�, uporz�dkowan� wiedz� na temat zasad zarz�dzania zmianami w organizacjach, przyczyn, proces�w i wynikaj�cych z nich skutk�w", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W17", Opis = "ma pog��bion� wiedz� o wsp�czesnych pogl�dach oraz ich ewolucji, na temat wybranych struktur organizacji, instytucji i podmiot�w gospodarczych oraz wi�zi spo�ecznych w nich funkcjonuj�cych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W18", Opis = "ma podstawow� wiedz� na temat praw autorskich, prawa wynalazczego i patentowego i rozumie zasady ich funkcjonowania", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W19", Opis = "rozumie poj�cie przedsi�biorczo�ci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_W20", Opis = "ma podstawow� wiedz� na temat tworzenia i rozwoju form przedsi�biorczo�ci indywidualnej", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_W21", Opis = "posiada wiedz� zar�wno z dziedziny nauk humanistycznych i spo�ecznych, jak i ekonomicznych oraz technicznych", RodzajEfektuId = wiedzaEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U01", Opis = "potrafi wykorzystywa� podstawow� wiedz� teoretyczn� z zakresu zarz�dzania oraz powi�zanych z ni� dyscyplin w celu interpretowania zjawisk i problem�w spo�ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U02", Opis = "potrafi wykorzystywa� wiedz� teoretyczn� z zakresu zarz�dzania oraz powi�zanych z ni� dyscyplin w celu opisywania i praktycznego analizowania jednostkowych proces�w i zjawisk spo�eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U03", Opis = "posiada elementarne umiej�tno�ci badawcze pozwalaj�ce na analizowanie przyk�ad�w bada� oraz konstruowanie i prowadzenie prostych bada� empirycznych, potrafi opracowa� i zaprezentowa� ich wyniki", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U04", Opis = "potrafi krytycznie dobiera� gromadzone dane i metody badawcze w celu formu�owania w�asnych wniosk�w i opinii", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U05", Opis = "potrafi w�a�ciwie analizowa� przyczyny i przebieg wybranych proces�w i zjawisk spo�eczno-ekonomicznych w obszarze zarz�dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U06", Opis = "potrafi pos�ugiwa� si� podstawowymi uj�ciami teoretycznymi w celu analizowania motyw�w i wzor�w ludzkich zachowa�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U07", Opis = "potrafi stawia� proste hipotezy badawcze oraz je weryfikowa�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U08", Opis = "potrafi wykorzysta� standardowe metody i narz�dzia badawcze w celu prognozowania praktycznych skutk�w proces�w i zjawisk spo�eczno-ekonomicznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U09", Opis = "potrafi konstruowa� proste modele proces�w spo�ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U10", Opis = "potrafi generowa� rozwi�zania konkretnych problem�w gospodarczych i prognozowa� przebieg ich rozwi�zywania oraz przewidywa� skutki planowanych dzia�a�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U11", Opis = "potrafi pos�ugiwa� si� wybranymi regu�ami prawnymi w rozwi�zywaniu konkretnych zada� z zakresu zarz�dzania", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U12", Opis = "potrafi pos�ugiwa� si� regu�ami zawodowymi i normami etycznymi oraz dostrzega i analizuje dylematy etyczne w podejmowanej dzia�alno�ci", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U13", Opis = "potrafi powi�za� posiadan� wiedz� teoretyczn� z zakresu zarz�dzania z praktycznymi umiej�tno�ciami i do�wiadczeniami nabytymi podczas praktyki zawodowej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U14", Opis = "potrafi inspirowa� procesy gospodarcze, animowa� prace nad rozwojem uczestnik�w proces�w zarz�dzania oraz wspiera� ich samodzielno�� w zdobywaniu wiedzy", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U15", Opis = "potrafi oceni� przydatno�� typowych metod, procedur i odpowiednich praktyk do realizacji zada� zwi�zanych z r�nymi sferami dzia�alno�ci spo�eczno-ekonomicznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U16", Opis = "posiada umiej�tno�� prezentowania w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je w�a�ciw� argumentacj�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U17", Opis = "potrafi dokona� obserwacji zjawisk spo�ecznych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U18", Opis = "potrafi w�a�ciwie analizowa� i interpretowa� zaobserwowane zjawiska spo�eczne", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U19", Opis = "potrafi zaobserwowane i zinterpretowane zjawiska podda� pog��bionej ocenie teoretycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U20", Opis = "posiada pog��bion� umiej�tno�� sporz�dzania prac pisemnych w j�zyku polskim i wybranym j�zyku obcym, traktuj�cych o wybranych zagadnieniach szczeg�owych z zakresu zarz�dzania oraz dziedzin pokrewnych", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U21", Opis = "posiada umiej�tno�� prezentowania w formie pisemnej w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je argumentacj� w kontek�cie wybranych uj�� teoretycznych z wykorzystaniem r�nych �r�de�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U22", Opis = "posiada pog��bion� umiej�tno�� swobodnej wypowiedzi w j�zyku polskim i wybranym j�zyku obcym, traktuj�cych o wybranych zagadnieniach szczeg�owych z zakresu zarz�dzania, wi���c je z dyscyplinami pokrewnymi", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U23", Opis = "posiada umiej�tno�� prezentowania w formie ustnej w�asnych pomys��w, w�tpliwo�ci i sugestii, popieraj�c je argumentacj� w kontek�cie wybranych uj�� teoretycznych z wykorzystaniem r�nych �r�de�", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_U24", Opis = "posiada umiej�tno�� swobodnej wypowiedzi w mowie i pi�mie w zakresie zarz�dzania, zgodnie z wymaganiami okre�lonymi dla poziomu B2+ Europejskiego Systemu Opisu Kszta�cenia J�zykowego", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_U25", Opis = "potrafi przystosowa� si� do dynamicznie zmieniaj�cego si� rynku pracy, dzi�ki posiadaniu wiedzy og�lnej i specjalistycznej", RodzajEfektuId = umiejetnosciEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K01", Opis = "ma �wiadomo�� poziomu swojej wiedzy i umiej�tno�ci, rozumie potrzeb� sta�ego dokszta�cania zawodowego i rozwoju osobistego, dokonuje samooceny w�asnych kompetencji i doskonali umiej�tno�ci, wyznacza kierunki w�asnego rozwoju i samokszta�cenia", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K02", Opis = "potrafi dokona� analizy w�asnych dzia�a� i wskaza� ewentualne obszary wymagaj�ce modyfikacji w przysz�ym dzia�aniu", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K03", Opis = "jest przygotowany do aktywnego uczestnictwa i pracy w zespo�ach zadaniowych, organizacjach i instytucjach realizuj�cych dzia�ania gospodarcze", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K04", Opis = "potrafi si� elastycznie dostosowa� do pe�nienia r�nych funkcji w zespo�ach zadaniowych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K05", Opis = "jest przygotowany do kierowania zespo�ami zadaniowymi", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K06", Opis = "jest �wiadomy hierarchii i stratyfikacji priorytet�w i jest w stanie dokonywa� optymalnego wyboru priorytet�w przy planowaniu zada� dla siebie oraz dla innych", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K07", Opis = "ma przekonanie o wadze zachowania si� w spos�b profesjonalny, przestrzegania zasad etyki menad�erskiej oraz spo�ecznej odpowiedzialno�ci organizacji", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K08", Opis = "dostrzega i formu�uje problemy moralne i dylematy etyczne zwi�zane z w�asn� i cudz� prac�, poszukuje optymalnych rozwi�za�, post�puje zgodnie z zasadami etyki", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K09", Opis = "odpowiedzialnie przygotowuje si� do swojej pracy, projektuje i wykonuje dzia�ania w obszarze zarz�dzania posi�kuj�c si� analiz� systemow� i wielokryterialn�", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K10", Opis = "ma �wiadomo�� zasad i nowoczesnych instrument�w zarz�dzania projektami", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K11", Opis = "ma przekonanie o potrzebie ci�g�ego uzupe�niania i doskonalenia w�asnej wiedzy i umiej�tno�ci, jest w stanie w�a�ciwie zidentyfikowa� jej �r�d�a i zakres w uj�ciu interdyscyplinarnym", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "K_K12", Opis = "ma przekonanie o sensie, warto�ci i potrzebie podejmowania dzia�a� gospodarczych w �rodowisku spo�ecznym; jest gotowy do podejmowania wyzwa� zawodowych; wykazuje aktywno��, podejmuje trud i odznacza si� wytrwa�o�ci� w realizacji indywidualnych i zespo�owych dzia�a� profesjonalnych w zakresie zarz�dzania, uwzgl�dniaj�c teoretyczne i praktyczne przes�anki zarz�dzania ryzykiem", RodzajEfektuId = kompetencjeEfekt.Id },
                new Efekt() { PoziomId = IIst.Id, WydzialId = wydzialZarzawPlocku.Id, Skrot = "U_K13", Opis = "rozumie potrzeb� ustawicznego samorozwoju i wykorzystania w tym procesie nowoczesnych technologii charakteryzuj�cych spo�ecze�stwo informacyjne, z poszanowaniem praw w�asno�ci intelektualnej", RodzajEfektuId = kompetencjeEfekt.Id }


            );

            context.FormyPracy.AddOrUpdate(x => x.FormaPracyId,
                new FormaPracy() { FormaPracyId = 1, Opis = "Zapozanie si� z literatur� przedmiotu" },
                new FormaPracy() { FormaPracyId = 2, Opis = "Przygotowanie si� do zaj��" },
                new FormaPracy() { FormaPracyId = 3, Opis = "Przygotowanie si� do kolokwi�w" },
                new FormaPracy() { FormaPracyId = 4, Opis = "Realizacja zadanych �wicze� i zada�" },
                new FormaPracy() { FormaPracyId = 5, Opis = "Przygotowanie sprawozdania z �wicze�" },
                new FormaPracy() { FormaPracyId = 6, Opis = "Przygotowanie projektu / pracy" },
                new FormaPracy() { FormaPracyId = 7, Opis = "Przygotowanie si� i udzia� w egzaminie" }
            );
        }
    }
}
