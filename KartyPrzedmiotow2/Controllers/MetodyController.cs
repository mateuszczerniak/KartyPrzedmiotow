using KartyPrzedmiotow2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KartyPrzedmiotow2.Controllers
{
    public class MetodyController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MetodyDydaktyczne()
        {
            var context = new Models.Context();
            var metodyDydaktyczne = context.Metody.ToList();
            var lista = metodyDydaktyczne.OrderBy(md=>md.GrupyMetodDydaktycznychId).Select(md => new MetodyDydaktyczneListElement()
            {
                Id = md.Id,
                IdGrupy = md.GrupyMetodDydaktycznychId,
                Grupa = md.GrupyMetodDydaktycznych.Nazwa,
                Nazwa = md.Nazwa,
                LiczbaProgramow = md.Programy.Count(),
            });
            return View(lista);
        }

        public ActionResult MetodyOceniania()
        {
            var context = new Models.Context();
            var metodyOceniania = context.MetodyOceniania.ToList();
            var lista = metodyOceniania.Select(mo => new MetodyOcenianiaListElement()
            {
                Id = mo.Id,
                Nazwa = mo.Nazwa,
                LiczbaProgramow = mo.Programy.Count(),
            });
            return View(lista);
        }
        // GET: Metody/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult MetodyDydaktyczneCreate()
        {
            var context = new Models.Context();
            var grupyMetod = new GrupyMetodList();
            var grupyMetodDydaktycznych = new GrupyMetodDydaktycznych();
            grupyMetod.GrupyMetod = context.GrupyMetodDydaktycznych.Select(w =>
                new SelectListItem()
                {
                    Text = w.Nazwa,
                    Value = w.Id.ToString()
                }).ToList();
            return View(grupyMetod);
        }

        [HttpPost]
        public ActionResult MetodyDydaktyczneCreate(MetodyDydaktyczne model)
        {
            var context = new Models.Context();
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            context.Metody.Add(model);
            context.SaveChanges();

            return RedirectToAction("MetodyDydaktyczne");
        }

        public ActionResult MetodyOcenianiaCreate()
        {
            return View();
        }
        // POST: Metody/Create
        [HttpPost]
        public ActionResult MetodyOcenianiaCreate(MetodyOceniania model)
        {
            var context = new Models.Context();
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            context.MetodyOceniania.Add(model);
            context.SaveChanges();

            return RedirectToAction("OperatingMode");
        }

        // GET: Metody/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult MetodyDydaktyczneDelete(int id)
        {
            var context = new Models.Context();
            var model = context.Metody.Find(id);
            if (model.Programy.Any())
                throw new Exception("Nie można usunąć tej metody!");

            context.Metody.Remove(model);
            context.SaveChanges();

            return RedirectToAction("MetodyDydaktyczne");
        }

        //GET: Metody/Delete/5
        public ActionResult MetodyOcenianiaDelete(int id)
        {
            var context = new Models.Context();
            var model = context.MetodyOceniania.Find(id);
            if (model.Programy.Any())
                throw new Exception("Nie można usunąć tej metody!");

            context.MetodyOceniania.Remove(model);
            context.SaveChanges();

            return RedirectToAction("MetodyOceniania");
        }

        // POST: Metody/Delete/5
        //[HttpPost]
        //public ActionResult MetodyOcenianiaDelete(int id)
        //{
        //    try
        //    {
        //         TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
