using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Colegio.Models
{
    public class ColegioDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Seccion> Secciones { get; set; }

        public DbSet<EstudianteSeccion> EstudiantesSeccion { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public ColegioDbContext()
            : base("ColegioDb")
        {
            this.Configuration.LazyLoadingEnabled = false;
        } // Nombre de la conexion de la base de datos.
    }
}