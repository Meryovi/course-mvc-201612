using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Colegio.Models;

namespace Colegio.Controllers
{
    public class MateriasController : BaseController
    {
        // GET: Materias
        public ActionResult Index()
        {
            return View(dbContext.Materias.ToList());
        }

        // GET: Materias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = dbContext.Materias.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // GET: Materias/Create
        public ActionResult Create()
        {
            var materia = new Materia();

            return View(materia);
        }

        // POST: Materias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Materia materia)
        {
            if (ModelState.IsValid)
            {
                dbContext.Materias.Add(materia);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materia);
        }

        // GET: Materias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = dbContext.Materias.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // POST: Materias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Materia materia)
        {
            if (ModelState.IsValid)
            {
                dbContext.Entry(materia).State = EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materia);
        }

        // GET: Materias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materia materia = dbContext.Materias.Find(id);
            if (materia == null)
            {
                return HttpNotFound();
            }
            return View(materia);
        }

        // POST: Materias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Materia materia = dbContext.Materias.Find(id);
            dbContext.Materias.Remove(materia);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
