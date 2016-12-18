using Colegio.ActionFilters;
using Colegio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colegio.Controllers
{
    [ValidarAccesoFilter(UsuarioNivel.Administrador)]
    public class EstudiantesController : BaseController
    {
        // Esto se realiza de forma automatica si no definimos un constructor.
        public EstudiantesController()
            : base()
        {

        }

        [ValidarAccesoFilter(UsuarioNivel.Usuario)]
        public ActionResult Index()
        {
            var estudiantes = dbContext.Estudiantes;

            return View(estudiantes);
        }

        // GET: Estudiantes

        [HttpGet]
        public ActionResult Registrar()
        {
            var estudiante = new Estudiante();

            // Datos por defecto de la vista.
            estudiante.FechaNacimiento = DateTime.Now.AddYears(-18);
            estudiante.FechaMatriculacion = DateTime.Now;

            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Registrar(Estudiante estudiante)
        {
            bool estudianteExiste = dbContext.Estudiantes
                .Any(e => e.Matricula == estudiante.Matricula);

            if (estudianteExiste)
                ModelState.AddModelError("Matricula", "Ya existe un estudiante con esta matricula");

            if (ModelState.IsValid)
            {
                estudiante.FechaMatriculacion = DateTime.Now;

                dbContext.Estudiantes.Add(estudiante);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(estudiante);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var estudiante = dbContext.Estudiantes
                .FirstOrDefault(e => e.Id == id);

            if (estudiante == null)
                return HttpNotFound();

            return View(estudiante);
        }

        [HttpPost]
        public ActionResult Editar(int id, Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                estudiante.Id = id;

                dbContext.Estudiantes.Attach(estudiante);
                dbContext.Entry(estudiante).State = EntityState.Modified;

                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(estudiante);
        }

        public ActionResult Eliminar(int id)
        {
            var estudiante = dbContext.Estudiantes
                .FirstOrDefault(e => e.Id == id);

            if (estudiante == null)
                return HttpNotFound();

            dbContext.Estudiantes.Remove(estudiante);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}