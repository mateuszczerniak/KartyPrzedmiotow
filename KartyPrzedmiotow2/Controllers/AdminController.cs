using KartyPrzedmiotow2.Migrations;
using KartyPrzedmiotow2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        public ActionResult Seed()
        {
            var context = new Context();
            var config = new Configuration();
            config.PublicSeed(context);
            return Content("ok");
        }


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Uzytkownicy()
        {
            var context = new Models.Context();
            var users = context.Users
                .Include(u => u.Tytuly)
                .Include(u => u.Wydzialy).ToList();
            var roles = context.Roles.ToList();

            var lista = users.Select(u => new UzytkownikListElement()
            {
                Id = u.Id,
                Imie = u.Imie,
                Nazwisko = u.Nazwisko,
                Tytuly = string.Join(" " , u.Tytuly.OrderBy(t => t.Kolejnosc).Select(t=>t.Nazwa)),
                Role = string.Join(", ", u.Roles.Select(r=>roles.First(rr=>rr.Id == r.RoleId).Name)),
                Wydzialy = string.Join(", ", u.Wydzialy.Select(t => t.Wydzial.Nazwa)),

            });

            return View(lista);

        }

        public ActionResult UserEdit(string id)
        {
            var context = new Models.Context();
            var user = context.Users
                  .Include(u => u.Tytuly)
                  .Include(u => u.Wydzialy).First(u=>u.Id == id);
            var model = new UserEditViewModel();
            model.Id = id;
            model.Imie = user.Imie;
            model.Nazwisko = user.Nazwisko;
            model.WybraneRole = user.Roles.Select(r => r.RoleId).ToList();
            model.WybraneTytuly = user.Tytuly.Select(r => r.Id).ToList();
            model.WybraneWydzialy = user.Wydzialy.Select(r => r.WydzialId).ToList();

            UserEditViewModelStale(context, model);

            return View(model);
        }

        [HttpPost]
        public ActionResult UserEdit(UserEditViewModel model)
        {
            var context = new Models.Context();
            if (!ModelState.IsValid)
            {
                UserEditViewModelStale(context, model);
                return View(model);
            }

            var user = context.Users.First(u => u.Id == model.Id);
            user.Imie = model.Imie;
            user.Nazwisko = model.Nazwisko;

            var wydzialyDoUsuniecia = user.Wydzialy.Where(w => !model.WybraneWydzialy.Any(ww => ww == w.Id)).ToList();
            wydzialyDoUsuniecia.ForEach(w => user.Wydzialy.Remove(w));
            var tytulyDoUsuniecia = user.Tytuly.Where(w => !model.WybraneTytuly.Any(ww => ww == w.Id)).ToList();
            tytulyDoUsuniecia.ForEach(w => user.Tytuly.Remove(w));
            var roleDoUsuniecia = user.Roles.Where(w => !model.WybraneRole.Any(ww => ww == w.RoleId)).ToList();
            roleDoUsuniecia.ForEach(w => user.Roles.Remove(w));

            var wydzialyDoDodania = model.WybraneWydzialy.Where(ww => !user.Wydzialy.Any(w => w.Id == ww)).ToList();
            wydzialyDoDodania.ForEach(ww =>
            {
                user.Wydzialy.Add(new UzytkownikWydzialy()
                {
                    WydzialId = ww
                });
            });
            var tytulyDoDodania = model.WybraneTytuly.Where(ww => !user.Tytuly.Any(w => w.Id == ww)).ToList();
            tytulyDoDodania.ForEach(ww =>
            {
                var t = context.Tytuly.Find(ww);
                user.Tytuly.Add(t);
            });
            var roleDoDodania = model.WybraneRole.Where(ww => !user.Roles.Any(w => w.RoleId == ww)).ToList();
            roleDoDodania.ForEach(ww =>
            {
                user.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole()
                {
                    RoleId = ww
                });
            });

            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("Uzytkownicy");
        }


        public ActionResult Wydzialy()
        {
            var context = new Models.Context();
            var wydzialy = context.Wydzialy
                .Include("Program")
                .Include("Kierunki")
                .Include("Uzytkownicy").ToList();

            var lista = wydzialy.Select(u => new WydzialListElement()
            {
                Id = u.Id,
                Nazwa = u.Nazwa,
                LiczbaProgramow = u.Program.Count(),
                LiczbaKierunkow = u.Kierunki.Count(),
                LiczbaUzytkownikow = u.Uzytkownicy.Count(),

            });

            return View(lista);

        }

        public ActionResult WydzialCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WydzialCreate(Wydzial model)
        {
            var context = new Models.Context();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            context.Wydzialy.Add(model);
            context.SaveChanges();

            return RedirectToAction("Wydzialy");
        }

        public ActionResult WydzialDelete(int id)
        {
            var context = new Models.Context();
            var model = context.Wydzialy.Find(id);
            if (model.Kierunki.Any() || model.Program.Any() || model.Uzytkownicy.Any())
                throw new Exception("Nie można usunąć tego wydziału!");

            context.Wydzialy.Remove(model);
            context.SaveChanges();

            return RedirectToAction("Wydzialy");
        }

        public ActionResult Kierunki(int id)
        {
            var context = new Models.Context();
            var Kierunki = context.Kierunki
                .Include("Program")
                .Include("Specjalnosci")
                .Where(k=>k.WydzialId == id).ToList();

            var lista = Kierunki.Select(u => new KierunekListElement()
            {
                Id = u.Id,
                Nazwa = u.Nazwa,
                LiczbaProgramow = u.Program.Count(),
                LiczbaSpecjalnosci = u.Specjalnosci.Count(),
            });

            ViewBag.WydzialId = id;

            return View(lista);

        }

        public ActionResult KierunekCreate(int wydzialId)
        {
            var model = new Kierunek()
            {
                WydzialId = wydzialId
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult KierunekCreate(Kierunek model)
        {
            var context = new Models.Context();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            context.Kierunki.Add(model);
            context.SaveChanges();

            return RedirectToAction("Kierunki", new { id = model.WydzialId });
        }

        public ActionResult KierunekDelete(int id)
        {
            var context = new Models.Context();
            var model = context.Kierunki.Find(id);
            if (model.Specjalnosci.Any() || model.Program.Any())
                throw new Exception("Nie można usunąć tego kierunku!");
            var wydzialId = model.WydzialId;
            context.Kierunki.Remove(model);
            context.SaveChanges();

            return RedirectToAction("Kierunki", new { id = wydzialId });
        }

        public ActionResult Specjalnosci(int id)
        {
            var context = new Models.Context();
            var kierunek = context.Kierunki.Include("Specjalnosci.Programy").First(k=>k.Id == id);

            var lista = kierunek.Specjalnosci.Select(u => new SpecjalnoscListElement()
            {
                Id = u.Id,
                Nazwa = u.Nazwa,
                LiczbaProgramow = u.Programy.Count(),
            });

            ViewBag.KierunekId = id;
            ViewBag.WydzialId = kierunek.WydzialId;

            return View(lista);

        }

        public ActionResult SpecjalnoscCreate(int kierunekId)
        {
            var model = new Specjalnosc()
            {
                KierunekId = kierunekId
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult SpecjalnoscCreate(Specjalnosc model)
        {
            var context = new Models.Context();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            context.Specjalnosci.Add(model);
            context.SaveChanges();

            return RedirectToAction("Specjalnosci", new { id = model.KierunekId });
        }

        public ActionResult SpecjalnoscDelete(int id)
        {
            var context = new Models.Context();
            var model = context.Specjalnosci.Find(id);
            if (model.Programy.Any())
                throw new Exception("Nie można usunąć tego kierunku!");
            var kierunekId = model.KierunekId;
            context.Specjalnosci.Remove(model);
            context.SaveChanges();

            return RedirectToAction("Specjalnosci", new { id = kierunekId });
        }

        private void UserEditViewModelStale(Models.Context context, UserEditViewModel model)
        {
            var wydzialy = context.Wydzialy.ToList();
            var tytuly = context.Tytuly.OrderBy(t => t.Kolejnosc).ToList();
            var role = context.Roles.ToList();

            model.Wydzialy = wydzialy.Select(w => new SelectListItem()
            {
                Value = w.Id.ToString(),
                Text = w.Nazwa,
                Selected = model.WybraneWydzialy.Any(ww=>ww == w.Id)
            }).ToList();

            model.Tytuly = tytuly.Select(w => new SelectListItem()
            {
                Value = w.Id.ToString(),
                Text = w.Nazwa,
                Selected = model.WybraneTytuly.Any(ww => ww == w.Id)
            }).ToList();

            model.Role = role.Select(w => new SelectListItem()
            {
                Value = w.Id,
                Text = w.Name,
                Selected = model.WybraneRole.Any(ww => ww == w.Id)
            }).ToList();
        }
    }
}