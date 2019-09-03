using KartyPrzedmiotow2.Models;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace KartyPrzedmiotow2.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly Dictionary<string, string> MetodySkroty;

        public HomeController()
        {
            MetodySkroty = new Dictionary<string, string>();
            MetodySkroty.Add("Podające", "MP");
            MetodySkroty.Add("Problemowe", "MC");
            MetodySkroty.Add("Praktyczne", "MS");
            MetodySkroty.Add("Eksponujące", "ME");
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        [Authorize(Roles = "Dziekan, Biuro, Wykładowca")]
        public ActionResult Index()
        {
            ViewBag.Dziekan = User.IsInRole("Dziekan");
            ViewBag.Biuro = User.IsInRole("Biuro");

            var context = new Models.Context();
            var userID = User.Identity.GetUserId();
            var user = context.Users.Include("Wydzialy.Wydzial.Program").FirstOrDefault(u => u.Id == userID);
            if(user == null)
            {
                AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                return RedirectToAction("Index", "Home");
            }
            List<Program> przedmiotWProgramach;
            if (ViewBag.Dziekan || ViewBag.Biuro)
            {
                przedmiotWProgramach = user.Wydzialy.SelectMany(w=>w.Wydzial.Program).Where(p=>!p.Usuniety.HasValue).ToList();
            }
            else
            {
                przedmiotWProgramach = context.ProgramyStudiow.Where(p=>p.WykladowcaId == userID).Where(p => !p.Usuniety.HasValue).ToList();
            }
            return View(przedmiotWProgramach);
        }

        [Authorize(Roles = "Dziekan, Biuro")]
        public ActionResult NowaKarta()
        {
            var karta = new NowaKarta();
            var context = new Models.Context();
            UzupelnijProgramStudiow(context, karta);
            return View(karta);
        }

        [Authorize(Roles = "Dziekan, Biuro")]
        public ActionResult EdytujKarta(int id)
        {
            var context = new Models.Context();
            var program = context.ProgramyStudiow.Where(p => !p.Usuniety.HasValue).FirstOrDefault(p => p.Id == id);
            var karta = new NowaKarta()
            {
                Id = program.Id,
                WydzialId = program.WydzialId,
                KierunekId = program.KierunekId,
                PoziomId = program.PoziomId,
                ProfilKsztalceniaId = program.ProfilKsztalceniaId,
                ObszarKsztalceniaId = program.ObszarKsztalceniaId,
                GrupaPrzedmiotowId = program.GrupaPrzedmiotowId,
                SemestrId = program.SemestrId,
                FormaZaliczeniaId = program.FormaZaliczeniaId,
                WykladowcaId = program.WykladowcaId,
                NazwaPrzedmiotu = program.Nazwa,
                SpecjalnoscId = program.SpecjalnoscId,
                Kod = program.Kod,
                DoWyboru = program.PrzedmiotDoWyboru,
                ECTS = program.ECTS
            };
            UzupelnijProgramStudiow(context, karta);
            karta.Godziny.ForEach(g =>
            {
                var znanaGodzina = program.LiczbyGodzin.FirstOrDefault(lg => lg.TypLiczbaGodzinId == g.TypLiczbGodzinId);
                if (znanaGodzina != null)
                {
                    g.Stacjonarne = znanaGodzina.Stacjonarne;
                    g.Niestacjonarne = znanaGodzina.Niestacjonarne;
                }
            });
            return View("NowaKarta", karta);
        }

        [Authorize(Roles = "Dziekan, Biuro")]
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var context = new Models.Context();
            var program = context.ProgramyStudiow.Where(p => !p.Usuniety.HasValue).FirstOrDefault(ps => ps.Id == id);
            program.Usuniety = DateTime.Now;
            context.Entry(program).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Dziekan, Biuro")]
        [HttpPost]
        public ActionResult NowyProgram(NowaKarta nowyProgram)
        {
            var context = new Models.Context();
            var program = new Program();
            if (nowyProgram.Id > 0)
            {
                program = context.ProgramyStudiow.Where(p => !p.Usuniety.HasValue).FirstOrDefault(p => p.Id == nowyProgram.Id);
            }

            program.WydzialId = nowyProgram.WydzialId;
            program.KierunekId = nowyProgram.KierunekId;
            program.PoziomId = nowyProgram.PoziomId;
            program.ProfilKsztalceniaId = nowyProgram.ProfilKsztalceniaId;
            program.ObszarKsztalceniaId = nowyProgram.ObszarKsztalceniaId;
            program.GrupaPrzedmiotowId = nowyProgram.GrupaPrzedmiotowId;
            program.SemestrId = nowyProgram.SemestrId;
            program.FormaZaliczeniaId = nowyProgram.FormaZaliczeniaId;
            program.WykladowcaId = nowyProgram.WykladowcaId;
            program.Nazwa = nowyProgram.NazwaPrzedmiotu;
            program.SpecjalnoscId = nowyProgram.SpecjalnoscId;
            program.Kod = nowyProgram.Kod;
            program.PrzedmiotDoWyboru = nowyProgram.DoWyboru;
            program.ECTS = nowyProgram.ECTS;

            program.LiczbyGodzin.ForEach(lg =>
            {
                var godzina = nowyProgram.Godziny.FirstOrDefault(g => g.TypLiczbGodzinId == lg.TypLiczbaGodzinId);
                if(godzina != null)
                {
                    lg.Stacjonarne = godzina.Stacjonarne < 0 ? 0 : godzina.Stacjonarne;
                    lg.Niestacjonarne = godzina.Niestacjonarne < 0 ? 0 : godzina.Niestacjonarne;
                }
            });

            nowyProgram.Godziny.Where(godzina => !program.LiczbyGodzin.Any(lg => lg.TypLiczbaGodzinId == godzina.TypLiczbGodzinId)).ForEach(godzina =>
            {
                program.LiczbyGodzin.Add(new LiczbaGodzin()
                {
                    TypLiczbaGodzinId  = godzina.TypLiczbGodzinId,
                    Stacjonarne = godzina.Stacjonarne < 0 ? 0 : godzina.Stacjonarne,
                    Niestacjonarne = godzina.Niestacjonarne < 0 ? 0 : godzina.Niestacjonarne
                });
            });


            if (nowyProgram.Id > 0)
            {
                context.Entry(program).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                context.ProgramyStudiow.Add(program);
            }
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        private KartaDoWyswietlenia GetKartaDoWyswietlenia(int id)
        {
            var context = new Models.Context();
            var program = context.ProgramyStudiow
                .Where(p => !p.Usuniety.HasValue).FirstOrDefault(ps => ps.Id == id);

            var kartaDoWyswietlenia = new KartaDoWyswietlenia();

            kartaDoWyswietlenia.Id = id;
            kartaDoWyswietlenia.NazwaPrzedmiotu = program.Nazwa;
            kartaDoWyswietlenia.NazwaPrzedmiotuAng = program.PrzedmiotOpis.NazwaAngielski;
            kartaDoWyswietlenia.Wydzial = program.Wydzial.Nazwa;
            kartaDoWyswietlenia.Rok = program.PrzedmiotOpis.Rok;
            kartaDoWyswietlenia.Kierunek = program.Kierunek.Nazwa;
            kartaDoWyswietlenia.Poziom = program.Poziom.Nazwa;
            kartaDoWyswietlenia.Profil = program.ProfilKsztalcenia.Nazwa;
            kartaDoWyswietlenia.GrupaPrzedmiotow = program.GrupaPrzedmiotow.Nazwa;
            kartaDoWyswietlenia.Semestr = program.Semestr.Nazwa;
            kartaDoWyswietlenia.FormaZaliczenia = program.FormaZaliczenia.Nazwa;
            kartaDoWyswietlenia.PunktyECTS = program.ECTS;
            kartaDoWyswietlenia.PrzedmiotDoWyboru = program.PrzedmiotDoWyboru;
            kartaDoWyswietlenia.JezykZajec = program.PrzedmiotOpis.Jezyki.Nazwa;
            //wyklad, cwiczenia i suma godzin
            kartaDoWyswietlenia.Specjalnosc = program.Specjalnosc.Nazwa;
            //tytuly wykladowcy
            kartaDoWyswietlenia.Prowadzacy = string.Join(" ", program.Wykladowca.Tytuly.OrderBy(t => t.Kolejnosc).Select(t => t.Nazwa)) + " " + program.Wykladowca.Imie + " " + program.Wykladowca.Nazwisko;
            kartaDoWyswietlenia.OpisPrzedmiotu = program.PrzedmiotOpis.KrotkiOpis;
            kartaDoWyswietlenia.CelGlowny = program.PrzedmiotOpis.CelGlowny;
            kartaDoWyswietlenia.CelWiedza = program.PrzedmiotOpis.CelWiedza;
            kartaDoWyswietlenia.CelUmiejetnosci = program.PrzedmiotOpis.CelUmiejetnosci;
            kartaDoWyswietlenia.CelKompetencje = program.PrzedmiotOpis.CelKompetencje;
            kartaDoWyswietlenia.WarunkiZaliczenia = program.WarunkiZaliczenia;
            //kartaDoWyswietlenia.Godziny = program.LiczbyGodzin;



            kartaDoWyswietlenia.MetodyDydaktyczne = program.MetodyDydaktyczne.OrderBy(mdy => mdy.MetodyDydaktyczne.GrupyMetodDydaktycznychId).Select(md => new KartaDoWyswietleniaMetodyDydaktyczne()
            {
                Skrot = MetodySkroty[md.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa] + md.Skrot,
                Nazwa = md.MetodyDydaktyczne.Nazwa
            }).ToList();

            kartaDoWyswietlenia.MetodyOceniania = program.MetodyOceniania.Select(md => new KartaDoWyswietleniaMetodyOceniania()
            {
                Skrot = "MO" + md.Skrot,
                Nazwa = md.MetodyOceniania.Nazwa
            }).ToList();
            //
            kartaDoWyswietlenia.Tresci = program.Tresci.OrderBy(t => t.TypLiczbaGodzinId).ThenBy(t => t.Skrot).Select(tre => new KartaDoWyswietleniaTresci()
            {
                Skrot = tre.TypLiczbaGodzin.Nazwa.Substring(0, 1) + tre.Skrot,
                Opis = tre.Opis
            }).ToList();
            //
            kartaDoWyswietlenia.Literatura = program.PrzedmiotOpis.Literatury.Select(ll => new KartaDoWyswietleniaLiteratura()
            {
                Skrot = ll.TypLiteratura.Nazwa,
                Nazwa = ll.Nazwa
            }).ToList();
            //
            kartaDoWyswietlenia.Pytania = program.Pytania.Select(py => new KartaDoWyswietleniaPytania()
            {
                Nazwa = py.Nazwa
            }).ToList();
            //
            kartaDoWyswietlenia.Godziny = program.LiczbyGodzin
                .Where(lgn => lgn.Stacjonarne + lgn.Niestacjonarne > 0)
                .Select(lgn => new KartaDoWyswietleniaLiczbaGodzin()
                {
                    Typ = lgn.TypLiczabGodzin.Nazwa,
                    Stacjonarne = lgn.Stacjonarne,
                    Niestacjonarne = lgn.Niestacjonarne,
                    TypLiczbaGodzinId = lgn.TypLiczbaGodzinId
                }).ToList();

            var formaPracyGodziny = context.ProgramFormaPracyGodziny.Where(fpg => fpg.LiczbaGodzin.ProgramId == id).ToList();

            kartaDoWyswietlenia.FormaPracyStacjonarne = new List<KartaDoWyswietleniaFormaPracy>();

            foreach (var formaPracyId in formaPracyGodziny.Where(fp => fp.Dzienna).OrderBy(fp => fp.FormaPracyId).Select(fp => fp.FormaPracyId).Distinct())
            {
                var kartaDoWyswietleniaFormaPracy = new KartaDoWyswietleniaFormaPracy();
                kartaDoWyswietleniaFormaPracy.Nazwa = formaPracyGodziny.First(fp => fp.FormaPracyId == formaPracyId).FormaPracy.Opis;


                kartaDoWyswietleniaFormaPracy.Godziny = formaPracyGodziny.Where(fp => fp.Dzienna).Where(fp => fp.FormaPracyId == formaPracyId)
                    .Select(fp => new KartaDoWyswietleniaFormaPracyGodzina()
                    {
                        TypLiczbaGodzinId = fp.LiczbaGodzin.TypLiczbaGodzinId,
                        Godzin = fp.Godzin,
                        Nazwa = fp.LiczbaGodzin.TypLiczabGodzin.Nazwa
                    }).ToList();

                kartaDoWyswietlenia.FormaPracyStacjonarne.Add(kartaDoWyswietleniaFormaPracy);
            }

            kartaDoWyswietlenia.FormaPracyZaoczne = new List<KartaDoWyswietleniaFormaPracy>();

            foreach (var formaPracyId in formaPracyGodziny.Where(fp => !fp.Dzienna).OrderBy(fp => fp.FormaPracyId).Select(fp => fp.FormaPracyId).Distinct())
            {
                var kartaDoWyswietleniaFormaPracy = new KartaDoWyswietleniaFormaPracy();
                kartaDoWyswietleniaFormaPracy.Nazwa = formaPracyGodziny.First(fp => fp.FormaPracyId == formaPracyId).FormaPracy.Opis;


                kartaDoWyswietleniaFormaPracy.Godziny = formaPracyGodziny.Where(fp => !fp.Dzienna).Where(fp => fp.FormaPracyId == formaPracyId)
                    .Select(fp => new KartaDoWyswietleniaFormaPracyGodzina()
                    {
                        TypLiczbaGodzinId = fp.LiczbaGodzin.TypLiczbaGodzinId,
                        Godzin = fp.Godzin,
                        Nazwa = fp.LiczbaGodzin.TypLiczabGodzin.Nazwa
                    }).ToList();

                kartaDoWyswietlenia.FormaPracyZaoczne.Add(kartaDoWyswietleniaFormaPracy);

                kartaDoWyswietlenia.Efekty = program.Efekty.Where(e => e.Tresci.Any() || e.MetodyDydaktyczne.Any() || e.MetodyOceniania.Any())
                    .Select(e=> new KartaDoWyswietleniaEfekt()
                    {
                        Opis = e.Efekt.Opis,
                        WymaganiaWstepne = e.WymaganiaWstepne,
                        PrzedmiotoweEfektyKsztalcenia = e.PrzedmiotoweEfektyKsztalcenia,
                        Tresci = e.Tresci.OrderBy(t => t.Tresci.TypLiczbaGodzinId).ThenBy(t => t.Tresci.Skrot).Select(t => t.Tresci.TypLiczbaGodzin.Nazwa.Substring(0, 1) + t.Tresci.Skrot),
                        MetodyDydaktyczne = e.MetodyDydaktyczne.Select(md=> MetodySkroty[md.ProgramMetodyDydaktyczne.MetodyDydaktyczne.GrupyMetodDydaktycznych.Nazwa] + md.ProgramMetodyDydaktyczne.Skrot),
                        MetodyOceniania = e.MetodyOceniania.Select(mo=>"MO" + mo.ProgramMetodyOceniania.Skrot)
                    }).ToList();
            }

            return kartaDoWyswietlenia;
        }


        [Authorize(Roles = "Dziekan, Biuro")]
        [HttpGet]
        public ActionResult ShowPDF(int id)
        {
            var kartaDoWyswietlenia = GetKartaDoWyswietlenia(id);
            var nazwaheader = "--print-media-type --header-center \""+ kartaDoWyswietlenia.Kierunek+" | "+kartaDoWyswietlenia.Specjalnosc+" | "+kartaDoWyswietlenia.NazwaPrzedmiotu +" | Semestr "+ kartaDoWyswietlenia.Semestr+" | Rok akademicki "+kartaDoWyswietlenia.Rok+ "\"" ;
            var nazwafooter = "--page-offset 0 --footer-center [page] --footer-font-size 8";

            kartaDoWyswietlenia.PDF = true;

            //return View(kartaDoWyswietlenia);
            return new ViewAsPdf("Show",kartaDoWyswietlenia)
            {
                PageSize = Rotativa.Options.Size.A4,
                PageOrientation = Rotativa.Options.Orientation.Landscape,
                CustomSwitches = nazwaheader +" "+ nazwafooter,
                FileName = kartaDoWyswietlenia.Kierunek + "_" + kartaDoWyswietlenia.Specjalnosc + "_" + kartaDoWyswietlenia.NazwaPrzedmiotu + "_Semestr" + kartaDoWyswietlenia.Semestr + "_" + kartaDoWyswietlenia.Rok+".pdf"
            };
        }

        [Authorize(Roles = "Dziekan, Biuro")]
        [HttpGet]
        public ActionResult Show(int id)
        {
            var kartaDoWyswietlenia = GetKartaDoWyswietlenia(id);
            return View(kartaDoWyswietlenia);
        }



        private void UzupelnijProgramStudiow(Models.Context context, NowaKarta karta)
        {

            var userID = User.Identity.GetUserId();
            var user = context.Users.Include("Wydzialy.Wydzial.Kierunki.Specjalnosci").First(u => u.Id == userID);

            karta.Wydzialy = user.Wydzialy.Where(w=>w.Wydzial.Kierunki.Any(k=>k.Specjalnosci.Any()))
                .Select(w => w.Wydzial).Select(w =>
                  new NowaKartaWydzial()
                  {
                      Nazwa = w.Nazwa,
                      Id = w.Id,
                      Kierunki = w.Kierunki
                        .Where(k=>k.Specjalnosci.Any())
                        .Select(k => new NowaKartaKierunek()
                      {
                          Nazwa = k.Nazwa,
                          Id = k.Id,
                          Specjalnosci = k.Specjalnosci
                            .Select(s=> new NowaKartaSpecjalnosc()
                          {
                              Nazwa = s.Nazwa,
                              Id = s.Id
                          })
                      })
                }
            ).ToList();

            karta.Poziomy = context.Poziomy.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();
            karta.ProfileKsztalcenia = context.ProfileKsztalcenia.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();
            karta.ObszaryKsztalcenia = context.ObszaryKsztalcenia.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();
            karta.GrupyPrzedmiotow = context.GrupyPrzedmiotow.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();
            karta.Semestry = context.Semestry.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();
            karta.FormyZaliczenia = context.FormyZaliczenia.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }
            ).ToList();
            karta.Wykladowcy = context.Users.ToList().Select(w =>
                new SelectListItem()
                {
                    Text = string.Join(" ", w.Tytuly.OrderBy(t => t.Kolejnosc).Select(t => t.Nazwa)) + " " + w.Imie + " " + w.Nazwisko,
                    Value = w.Id.ToString()
                }
            ).ToList();

            karta.Godziny = context.TypyLiczbGodzin.Select(w =>
                new Godzina()
                {
                    Stacjonarne = 0,
                    Niestacjonarne = 0,
                    TypLiczbGodzinId = w.Id,
                    Nazwa = w.Nazwa
                }
            ).ToList();

        }
    }
}