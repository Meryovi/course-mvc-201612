using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto1.Models
{
    public class ColegioDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public ColegioDbContext()
            : base("ColegioDb") { } // Nombre de la conexion de la base de datos.
    }
}