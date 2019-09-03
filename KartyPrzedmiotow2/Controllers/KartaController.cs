using KartyPrzedmiotow2.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace KartyPrzedmiotow2.Controllers
{
    public class KartaController : Controller
    {
        // GET: Karta
        [Authorize]
        public ActionResult Wypelnij(int id)
        {
            var context = new Models.Context();
            var program = context.ProgramyStudiow
                .Where(p => !p.Usuniety.HasValue)
                .FirstOrDefault(p => p.Id == id);
            var dziekan = User.IsInRole("Dziekan");
            var userId = User.Identity.GetUserId();
            if (!dziekan && program.WykladowcaId != userId)
                return View("BrakDostepu");

            var karta = new Karta();
            karta.ProgramId = program.Id;
            if (program.PrzedmiotOpis == null)
                program.PrzedmiotOpis = new PrzedmiotOpis();
            karta.NazwaAngielski = program.PrzedmiotOpis.NazwaAngielski;
            karta.JezykiId = program.PrzedmiotOpis.JezykiId;
            karta.MaterialyId = program.PrzedmiotOpis.MaterialyId;
            karta.Tytuly = string.Join(" ", program.Wykladowca.Tytuly.OrderBy(t => t.Kolejnosc).Select(t=>t.Nazwa));
            karta.Imie = program.Wykladowca.Imie;
            karta.Nazwisko = program.Wykladowca.Nazwisko;
            karta.KrotkiOpis = program.PrzedmiotOpis.KrotkiOpis;
            karta.Rok = program.PrzedmiotOpis.Rok;
            karta.CelGlowny = program.PrzedmiotOpis.CelGlowny;
            karta.CelKompetencje = program.PrzedmiotOpis.CelKompetencje;
            karta.CelUmiejetnosci = program.PrzedmiotOpis.CelUmiejetnosci;
            karta.CelWiedza = program.PrzedmiotOpis.CelWiedza;
            karta.WarunkiZaliczenia = program.WarunkiZaliczenia;
            karta.LiteraturyPodstawowe = program.PrzedmiotOpis.Literatury.Where(l=>l.TypLiteratura.Nazwa == "Podstawowa")
                .Select(k=>new KartaLiteratura() { Id = k.Id, Nazwa = k.Nazwa }).ToList();
            if (!karta.LiteraturyPodstawowe.Any())
                karta.LiteraturyPodstawowe.Add(new KartaLiteratura());
            karta.LiteraturyUzupelniajace = program.PrzedmiotOpis.Literatury.Where(l => l.TypLiteratura.Nazwa == "Uzupelniajaca")
                .Select(k => new KartaLiteratura() { Id = k.Id, Nazwa = k.Nazwa }).ToList();
            if (!karta.LiteraturyUzupelniajace.Any())
                karta.LiteraturyUzupelniajace.Add(new KartaLiteratura());
            karta.ZrodlaDodatkowe = program.PrzedmiotOpis.Literatury.Where(l => l.TypLiteratura.Nazwa == "Dodatkowe")
                .Select(k => new KartaLiteratura() { Id = k.Id, Nazwa = k.Nazwa }).ToList();
            if (!karta.ZrodlaDodatkowe.Any())
                karta.ZrodlaDodatkowe.Add(new KartaLiteratura());

            karta.MetodyPodajaceIds = program.MetodyDydaktyczne.Where(m => m.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Podające")
                .OrderBy(m=>m.Skrot)
                .Select(m => new WybranaMetoda { MetodaId = m.MetodyDydaktyczneId, Skrot = m.Skrot }).ToList();

            karta.MetodyPraktyczneIds = program.MetodyDydaktyczne.Where(m => m.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Praktyczne")
                .OrderBy(m => m.Skrot)
                .Select(m => new WybranaMetoda { MetodaId = m.MetodyDydaktyczneId, Skrot = m.Skrot }).ToList();

            karta.MetodyProblemoweIds = program.MetodyDydaktyczne.Where(m => m.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Problemowe")
                .OrderBy(m => m.Skrot)
                .Select(m => new WybranaMetoda { MetodaId = m.MetodyDydaktyczneId, Skrot = m.Skrot }).ToList();

            karta.MetodyEksponujaceIds = program.MetodyDydaktyczne.Where(m => m.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Eksponujące")
                .OrderBy(m => m.Skrot)
                .Select(m => new WybranaMetoda { MetodaId = m.MetodyDydaktyczneId, Skrot = m.Skrot }).ToList();

            karta.MetodyOcenianiaIds = program.MetodyOceniania
                .OrderBy(m => m.Skrot)
                .Select(m => new WybranaMetoda { MetodaId = m.MetodyOcenianiaId, Skrot = m.Skrot }).ToList();

            karta.Pytania = program.Pytania.Select(p=>new KartaPytanie() { Id = p.Id, Nazwa = p.Nazwa }).ToList();
            if (!karta.Pytania.Any())
                karta.Pytania.Add(new KartaPytanie());


            karta.Godziny = program.LiczbyGodzin.Where(lg => lg.Stacjonarne + lg.Niestacjonarne > 0)
                .Select(g => new KartaGodzina()
                {
                    TypLiczbaGodzinId = g.TypLiczabGodzin.Id,
                    Nazwa = g.TypLiczabGodzin.Nazwa,
                    Tresci = new List<KartaGodzinaTresci>(),
                    Stacjonarne = g.Stacjonarne,
                    Niestacjonarne = g.Niestacjonarne
                })
                .ToList();
            //dodano orderby do sortowania tresci
            program.Tresci.OrderBy(tre=>tre.Skrot).ForEach(t =>
            {
                var godziana = karta.Godziny.FirstOrDefault(kg => kg.TypLiczbaGodzinId == t.TypLiczbaGodzinId);
                godziana.Tresci.Add(new KartaGodzinaTresci()
                {
                    Nazwa = t.Opis,
                    Skrot = t.Skrot
                });
            });
            karta.Godziny.Where(g => !g.Tresci.Any())
                .ForEach(g => g.Tresci.Add(new KartaGodzinaTresci() { Skrot = 1 }));

            

            karta.Efekty = context.Efekty.Where(e => e.PoziomId == program.PoziomId && e.WydzialId == program.WydzialId)
                .OrderBy(e => e.RodzajEfektuId).ThenBy(e => e.Skrot)
                .Select(e => new KartaEfekt() {
                    Id = e.Id,
                    Opis = e.Opis,
                    Skrot = e.Skrot,
                    RodzajEfektuId = e.RodzajEfektuId,
                }).ToList();

            karta.Efekty.ForEach(e => e.Godziny = karta.Godziny.Select(kg => new KartaEfektGodzina()
            {
                TypLiczbaGodzinId = kg.TypLiczbaGodzinId,
                Nazwa = kg.Nazwa
            }).ToList());

            program.Efekty.ForEach(e =>
            {
                var kartaEfekt = karta.Efekty.FirstOrDefault(ke => e.EfektId == ke.Id);
                if (kartaEfekt != null)
                {
                    kartaEfekt.PrzedmiotoweEfektyKsztalcenia = e.PrzedmiotoweEfektyKsztalcenia;
                    kartaEfekt.WymaganiaWstepne = e.WymaganiaWstepne;
                    e.Tresci.ForEach(t =>
                    {
                        var godzina = kartaEfekt.Godziny.FirstOrDefault(keg => keg.TypLiczbaGodzinId == t.Tresci.TypLiczbaGodzinId);
                        godzina.WybraneTresci.Add(t.Tresci.Skrot);

                    });

                    kartaEfekt.WybraneMetodyPodajace = e.MetodyDydaktyczne.Where(md => md.ProgramMetodyDydaktyczne.MetodyDydaktyczne.GrupyMetodDydaktycznych.
                        Nazwa == "Podające").Select(md => md.ProgramMetodyDydaktyczne.Skrot).ToList();
                    kartaEfekt.WybraneMetodyEksponujace = e.MetodyDydaktyczne.Where(md => md.ProgramMetodyDydaktyczne.MetodyDydaktyczne.GrupyMetodDydaktycznych.
                        Nazwa == "Eksponujące").Select(md => md.ProgramMetodyDydaktyczne.Skrot).ToList();
                    kartaEfekt.WybraneMetodyPraktyczne = e.MetodyDydaktyczne.Where(md => md.ProgramMetodyDydaktyczne.MetodyDydaktyczne.GrupyMetodDydaktycznych.
                        Nazwa == "Praktyczne").Select(md => md.ProgramMetodyDydaktyczne.Skrot).ToList();
                    kartaEfekt.WybraneMetodyProblemowe = e.MetodyDydaktyczne.Where(md => md.ProgramMetodyDydaktyczne.MetodyDydaktyczne.GrupyMetodDydaktycznych.
                        Nazwa == "Problemowe").Select(md => md.ProgramMetodyDydaktyczne.Skrot).ToList();
                    kartaEfekt.WybraneMetodyOceniania = e.MetodyOceniania.Select(md => md.ProgramMetodyOceniania.Skrot).ToList();
                }

            });

            var rodzaje = karta.Efekty.Select(e => e.RodzajEfektuId).Distinct().ToList();

            karta.RodzajeEfektow = context.RodzajeEfektow
                .Where(re=> rodzaje.Contains(re.Id))
                .Select(re=> new KartaRodzajEfektu()
                {
                    Id = re.Id,
                    Nazwa = re.Nazwa
                })
                .ToList();

            karta.FormaPracy = context.FormyPracy.Select(fp => new KartaFormaPracy()
            {
                FormaPracyId = fp.FormaPracyId,
                Opis = fp.Opis
            }).ToList();

            karta.FormaPracy.ForEach(fp =>
            {
                for (var i = 0; i < karta.Godziny.Count; i++)
                {
                    fp.Dzienne.Add(new KartaFormaPracyGodzina()
                    {
                        TypLiczbaGodzinId = karta.Godziny[i].TypLiczbaGodzinId
                    });
                    fp.Zaoczne.Add(new KartaFormaPracyGodzina()
                    {
                        TypLiczbaGodzinId = karta.Godziny[i].TypLiczbaGodzinId
                    });
                }
            });

            program.LiczbyGodzin.ForEach(lg =>
            {
                lg.FormaPracyGodziny.ForEach(fp =>
                {
                    var kfp = karta.FormaPracy.FirstOrDefault(fpp => fpp.FormaPracyId == fp.FormaPracyId);
                    KartaFormaPracyGodzina godzina = null;
                    if(fp.Dzienna)
                        godzina = kfp.Dzienne.FirstOrDefault(d => d.TypLiczbaGodzinId == lg.TypLiczbaGodzinId);
                    else
                        godzina = kfp.Zaoczne.FirstOrDefault(d => d.TypLiczbaGodzinId == lg.TypLiczbaGodzinId);
                    godzina.Godzin = fp.Godzin;
                });
            });


            karta.ECTS = program.ECTS;

            UzupelnijKarta(karta);

            return View(karta);
        }
        
        [HttpPost]
        public ActionResult Wypelnij(Karta karta)
        {
            var context = new Models.Context();
            var program = context.ProgramyStudiow
                .Where(p => !p.Usuniety.HasValue)
                .FirstOrDefault(p => p.Id == karta.ProgramId);

            var dziekan = User.IsInRole("Dziekan");
            var userId = User.Identity.GetUserId();
            if (!dziekan && program.WykladowcaId != userId)
                return View("BrakDostepu");

            if (program.PrzedmiotOpis == null)
                program.PrzedmiotOpis = new PrzedmiotOpis();

            //ToDo: uzupelnic wartosci w program o wartosci z karta, bez imienia i nazwiska
            program.PrzedmiotOpis.NazwaAngielski = karta.NazwaAngielski;
            program.PrzedmiotOpis.JezykiId = karta.JezykiId;
            program.PrzedmiotOpis.MaterialyId = karta.MaterialyId;
            program.PrzedmiotOpis.Rok = karta.Rok;
            program.PrzedmiotOpis.KrotkiOpis = karta.KrotkiOpis;
            program.PrzedmiotOpis.CelGlowny = karta.CelGlowny;
            program.PrzedmiotOpis.CelKompetencje = karta.CelKompetencje;
            program.PrzedmiotOpis.CelUmiejetnosci = karta.CelUmiejetnosci;
            program.PrzedmiotOpis.CelWiedza = karta.CelWiedza;
            program.WarunkiZaliczenia = karta.WarunkiZaliczenia;


            //literatura podstawowa
            karta.LiteraturyPodstawowe = karta.LiteraturyPodstawowe.Where(lp => !string.IsNullOrWhiteSpace(lp.Nazwa)).ToList();

            var istniejacaLiteraturaPodstawowa = program.PrzedmiotOpis
                .Literatury
                .Where(l => l.TypLiteratura.Nazwa == "Podstawowa").ToList();

            var doUsuniecia = istniejacaLiteraturaPodstawowa
                .Where(l => !karta.LiteraturyPodstawowe.Any(lp => lp.Nazwa == l.Nazwa)).ToList();

            doUsuniecia.ForEach(u => program.PrzedmiotOpis.Literatury.Remove(u));

            var podstawiowyTypLiteratury = context.TypyLiteratury.First(tl => tl.Nazwa == "Podstawowa");

            var doDodania = karta.LiteraturyPodstawowe.Where(l => !istniejacaLiteraturaPodstawowa.Any(ist => ist.Nazwa == l.Nazwa)).ToList();
            doDodania.ForEach(dd =>
            {
                var literatura = context.Literatury.FirstOrDefault(l => l.Nazwa == dd.Nazwa && l.TypLiteratura.Nazwa == "Podstawowa");
                if(literatura == null)
                {
                    literatura = new Literatura();
                    literatura.Nazwa = dd.Nazwa;
                    literatura.TypLiteratura = podstawiowyTypLiteratury;
                }

                program.PrzedmiotOpis.Literatury.Add(literatura);
            });

            //literatura uzupelniajaca
            karta.LiteraturyUzupelniajace = karta.LiteraturyUzupelniajace.Where(lu => !string.IsNullOrWhiteSpace(lu.Nazwa)).ToList();

            var istniejacaLiteraturaUzupelniajaca = program.PrzedmiotOpis
                .Literatury
                .Where(l => l.TypLiteratura.Nazwa == "Uzupelniajaca").ToList();

            var doUsunieciaUzup = istniejacaLiteraturaUzupelniajaca
                .Where(l => !karta.LiteraturyUzupelniajace.Any(lp => lp.Nazwa == l.Nazwa)).ToList();

            doUsunieciaUzup.ForEach(v => program.PrzedmiotOpis.Literatury.Remove(v));

            var podstawiowyTypLiteraturyUzup = context.TypyLiteratury.First(tl => tl.Nazwa == "Uzupelniajaca");

            var doDodaniaUzup = karta.LiteraturyUzupelniajace.Where(l => !istniejacaLiteraturaUzupelniajaca.Any(ist => ist.Nazwa == l.Nazwa)).ToList();
            doDodaniaUzup.ForEach(dd =>
            {
                var literaturauzup = context.Literatury.FirstOrDefault(l => l.Nazwa == dd.Nazwa && l.TypLiteratura.Nazwa == "Uzupelniajaca" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "" +
                "");
                if (literaturauzup == null)
                {
                    literaturauzup = new Literatura();
                    literaturauzup.Nazwa = dd.Nazwa;
                    literaturauzup.TypLiteratura = podstawiowyTypLiteraturyUzup;
                }

                program.PrzedmiotOpis.Literatury.Add(literaturauzup);
            });
            //

            //zrodla dodatkowe
            karta.ZrodlaDodatkowe = karta.ZrodlaDodatkowe.Where(lu => !string.IsNullOrWhiteSpace(lu.Nazwa)).ToList();

            var istniejaceZrodlaDodatkowe = program.PrzedmiotOpis
                .Literatury
                .Where(l => l.TypLiteratura.Nazwa == "Dodatkowe").ToList();

            var doUsunieciaDodat = istniejaceZrodlaDodatkowe
                .Where(l => !karta.ZrodlaDodatkowe.Any(lp => lp.Nazwa == l.Nazwa)).ToList();

            doUsunieciaDodat.ForEach(v => program.PrzedmiotOpis.Literatury.Remove(v));

            var podstawiowyTypDodat = context.TypyLiteratury.First(tl => tl.Nazwa == "Dodatkowe");

            var doDodaniaDodat = karta.ZrodlaDodatkowe.Where(l => !istniejaceZrodlaDodatkowe.Any(ist => ist.Nazwa == l.Nazwa)).ToList();
            doDodaniaDodat.ForEach(dd =>
            {
                var zrodladodat = context.Literatury.FirstOrDefault(l => l.Nazwa == dd.Nazwa && l.TypLiteratura.Nazwa == "Dodatkowe");
                if (zrodladodat == null)
                {
                    zrodladodat = new Literatura();
                    zrodladodat.Nazwa = dd.Nazwa;
                    zrodladodat.TypLiteratura = podstawiowyTypDodat;
                }

                program.PrzedmiotOpis.Literatury.Add(zrodladodat);
            });
            //pytania

            karta.Pytania = karta.Pytania.Where(lp => !string.IsNullOrWhiteSpace(lp.Nazwa)).ToList();

            var istniejacaPytania = program.Pytania.ToList();

            var doUsunieciaPytania = istniejacaPytania
                .Where(l => !karta.Pytania.Any(lp => lp.Nazwa == l.Nazwa)).ToList();

            doUsunieciaPytania.ForEach(u => program.Pytania.Remove(u));

            var doDodaniaPytania = karta.Pytania.Where(l => !istniejacaPytania.Any(ist => ist.Nazwa == l.Nazwa)).ToList();
            doDodaniaPytania.ForEach(dd =>
            {
                var pytania = context.Pytania.FirstOrDefault(l => l.Nazwa == dd.Nazwa);
                if (pytania == null)
                {
                    pytania = new Pytanie();
                    pytania.Nazwa = dd.Nazwa;
                }

                program.Pytania.Add(pytania);
            });

            //metody podajace

            var doUsunieciaMP = program.MetodyDydaktyczne
                .Where(l => l.MetodyDydaktyczne.GrupyMetodDydaktycznych != null)
                .ToList();
            doUsunieciaMP.ForEach(v => context.ProgramMetody.Remove(v));

            for (var i = 0; i < karta.MetodyPodajaceIds.Count; i++)
            {
                var mp = new ProgramMetodyDydaktyczne();
                mp.MetodyDydaktyczne = context.Metody.Find(karta.MetodyPodajaceIds[i].MetodaId);
                mp.ProgramId = program.Id;
                mp.Skrot = karta.MetodyPodajaceIds[i].Skrot;
                program.MetodyDydaktyczne.Add(mp);
            }

            for (var i = 0; i < karta.MetodyPraktyczneIds.Count; i++)
            {
                var mc = new ProgramMetodyDydaktyczne();
                mc.MetodyDydaktyczne = context.Metody.Find(karta.MetodyPraktyczneIds[i].MetodaId);
                mc.ProgramId = program.Id;
                mc.Skrot = karta.MetodyPraktyczneIds[i].Skrot;
                program.MetodyDydaktyczne.Add(mc);
            }

            for (var i = 0; i < karta.MetodyProblemoweIds.Count; i++)
            {
                var ms = new ProgramMetodyDydaktyczne();
                ms.MetodyDydaktyczne = context.Metody.Find(karta.MetodyProblemoweIds[i].MetodaId);
                ms.ProgramId = program.Id;
                ms.Skrot = karta.MetodyProblemoweIds[i].Skrot;
                program.MetodyDydaktyczne.Add(ms);
            }

            for (var i = 0; i < karta.MetodyEksponujaceIds.Count; i++)
            {
                var me = new ProgramMetodyDydaktyczne();
                me.MetodyDydaktyczne = context.Metody.Find(karta.MetodyEksponujaceIds[i].MetodaId);
                me.ProgramId = program.Id;
                me.Skrot = karta.MetodyEksponujaceIds[i].Skrot;
                program.MetodyDydaktyczne.Add(me);
            }

            //metody oceniania
            var doUsunieciaMO = program.MetodyOceniania.ToList();

            doUsunieciaMO.ForEach(v => context.ProgramMetodyOceniania.Remove(v));

            for (var i = 0; i < karta.MetodyOcenianiaIds.Count; i++)
            {
                var mo = new ProgramMetodyOceniania();
                mo.MetodyOceniania = context.MetodyOceniania.Find(karta.MetodyOcenianiaIds[i].MetodaId);
                mo.ProgramId = program.Id;
                mo.Skrot = karta.MetodyOcenianiaIds[i].Skrot;
                program.MetodyOceniania.Add(mo);
            }

            // tresci

            program.Tresci.ToList()
                .ForEach(t => context.Tresci.Remove(t));

            karta.Godziny.ForEach(g =>
            {
                for(var i=0; i<g.Tresci.Count; i++)
                {
                    program.Tresci.Add(new Tresci()
                    {
                        Opis = g.Tresci[i].Nazwa,
                        Skrot = g.Tresci[i].Skrot,
                        TypLiczbaGodzinId = g.TypLiczbaGodzinId
                    });
                }
            });

            // efekty

            program.Efekty.ToList().ForEach(e=>
            {
                e.Tresci.ToList().ForEach(t => context.ProgramEfektTresci.Remove(t));
                e.MetodyDydaktyczne.ToList().ForEach(t => context.ProgramEfektMetodaDydaktyczna.Remove(t));
                e.MetodyOceniania.ToList().ForEach(t => context.ProgramEfektMetodaOceniania.Remove(t));
                context.ProgramEfekty.Remove(e);
            });

            karta.Efekty.ForEach(e =>
            {
                var metodyDydaktyczne = e.WybraneMetodyEksponujace.Select(g =>
                {
                    var metoda = program.MetodyDydaktyczne.FirstOrDefault(mt => mt.Skrot == g && mt.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Eksponujące");
                    return new ProgramEfektMetodaDydaktyczna()
                    {
                        ProgramMetodyDydaktyczne = metoda
                    };
                }).ToList();
                metodyDydaktyczne.AddRange(e.WybraneMetodyPodajace.Select(g =>
                {
                    var metoda = program.MetodyDydaktyczne.FirstOrDefault(mt => mt.Skrot == g && mt.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Podające");
                    return new ProgramEfektMetodaDydaktyczna()
                    {
                        ProgramMetodyDydaktyczne = metoda
                    };
                }).ToList());
                metodyDydaktyczne.AddRange(e.WybraneMetodyPraktyczne.Select(g =>
                {
                    var metoda = program.MetodyDydaktyczne.FirstOrDefault(mt => mt.Skrot == g && mt.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Praktyczne");
                    return new ProgramEfektMetodaDydaktyczna()
                    {
                        ProgramMetodyDydaktyczne = metoda
                    };
                }).ToList());
                metodyDydaktyczne.AddRange(e.WybraneMetodyProblemowe.Select(g =>
                {
                    var metoda = program.MetodyDydaktyczne.FirstOrDefault(mt => mt.Skrot == g && mt.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa == "Problemowe");
                    return new ProgramEfektMetodaDydaktyczna()
                    {
                        ProgramMetodyDydaktyczne = metoda
                    };
                }).ToList());

                var efekt = new ProgramEfekt()
                {
                    EfektId = e.Id,
                    WymaganiaWstepne = e.WymaganiaWstepne,
                    PrzedmiotoweEfektyKsztalcenia = e.PrzedmiotoweEfektyKsztalcenia,
                    Tresci = e.Godziny.SelectMany(g =>
                    {
                        var tresci = g.WybraneTresci.Select(t => program.Tresci.First(tt => tt.Skrot == t && tt.TypLiczbaGodzinId == g.TypLiczbaGodzinId));
                        return tresci.Select(t => new ProgramEfektTresc()
                        {
                            Tresci = t
                        });
                    }).ToList(),
                    MetodyDydaktyczne = metodyDydaktyczne,
                    MetodyOceniania = e.WybraneMetodyOceniania.Select(g =>
                    {
                        var metoda = program.MetodyOceniania.FirstOrDefault(mt => mt.Skrot == g);
                        return new ProgramEfektMetodaOceniania()
                        {
                            ProgramMetodyOceniania = metoda
                        };
                    }).ToList()
                };
                program.Efekty.Add(efekt);


            });

            program.LiczbyGodzin.ToList().ForEach(lg =>
            {
                lg.FormaPracyGodziny.ToList().ForEach(t => context.ProgramFormaPracyGodziny.Remove(t));
                lg.FormaPracyGodziny.Clear();
            });

            karta.FormaPracy.ForEach(fp =>
            {
                fp.Dzienne.ForEach(d =>
                {
                    var liczbaGodzin = program.LiczbyGodzin.FirstOrDefault(lg => lg.TypLiczbaGodzinId == d.TypLiczbaGodzinId);
                    liczbaGodzin.FormaPracyGodziny.Add(new ProgramFormaPracyGodzina()
                    {
                        Dzienna = true,
                        FormaPracyId = fp.FormaPracyId,
                        Godzin = d.Godzin,
                    });
                });

                fp.Zaoczne.ForEach(d =>
                {
                    var liczbaGodzin = program.LiczbyGodzin.FirstOrDefault(lg => lg.TypLiczbaGodzinId == d.TypLiczbaGodzinId);
                    liczbaGodzin.FormaPracyGodziny.Add(new ProgramFormaPracyGodzina()
                    {
                        Dzienna = false,
                        FormaPracyId = fp.FormaPracyId,
                        Godzin = d.Godzin,
                    });
                });
            });

            context.Entry(program).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();


            return Json(new { success = true });
        }

        private void UzupelnijKarta(Karta karta)
        {
            
            var context = new Models.Context();

            karta.Jezyki = context.JezykiObce.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.Materialy = context.Materialy.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.MetodyPodajace = context.Metody
                .Where(w => w.GrupyMetodDydaktycznych.Nazwa == "Podające")
                .Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.MetodyPraktyczne = context.Metody
                .Where(w => w.GrupyMetodDydaktycznych.Nazwa == "Praktyczne")
                .Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.MetodyProblemowe = context.Metody
                .Where(w => w.GrupyMetodDydaktycznych.Nazwa == "Problemowe")
                .Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.MetodyEksponujace = context.Metody
                .Where(w => w.GrupyMetodDydaktycznych.Nazwa == "Eksponujące")
                .Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.MetodyOceniania = context.MetodyOceniania
                .Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();

        }
        }
}