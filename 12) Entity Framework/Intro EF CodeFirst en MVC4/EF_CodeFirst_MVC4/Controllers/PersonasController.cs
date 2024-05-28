using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_CodeFirst_MVC4.Models;

namespace EF_CodeFirst_MVC4.Controllers
{
    public class PersonasController : Controller
    {
        private PersonaDBContext db = new PersonaDBContext();

        //
        // GET: /Personas/

        public ActionResult Index()
        {
            return View(db.Personas.ToList());
        }

        //
        // GET: /Personas/Details/5

        public ActionResult Details(string id = null)
        {
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        //
        // GET: /Personas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Personas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(persona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(persona);
        }

        //
        // GET: /Personas/Edit/5

        public ActionResult Edit(string id = null)
        {
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        //
        // POST: /Personas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Persona persona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(persona);
        }

        //
        // GET: /Personas/Delete/5

        public ActionResult Delete(string id = null)
        {
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        //
        // POST: /Personas/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Persona persona = db.Personas.Find(id);
            db.Personas.Remove(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}