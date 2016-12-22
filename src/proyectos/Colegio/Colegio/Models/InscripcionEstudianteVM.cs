using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colegio.Models
{
    public class InscripcionEstudianteVM
    {
        public Estudiante Estudiante { get; set; }

        public List<EstudianteSeccion> Secciones { get; set; }

        public IEnumerable<SelectListItem> ListaSecciones { get; set; }

        public InscripcionEstudianteVM()
        {
            Secciones = new List<EstudianteSeccion>();
        }
    }
}