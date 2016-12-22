using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Models
{
    [Table("EstudiantesSeccion")]
    public class EstudianteSeccion
    {
        public int Id { get; set; }

        [Display(Name = "Seccion")]
        public int SeccionId { get; set; }

        [Display(Name = "Estudiante")]
        public int EstudianteId { get; set; }

        public double Calificacion { get; set; }

        public EstadoEstudiante Estado { get; set; }

        [Display(Name = "Fecha de Inscripcion")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaInscripcion { get; set; }

        [ForeignKey("EstudianteId")]
        public virtual Estudiante Estudiante { get; set; }

        [ForeignKey("SeccionId")]
        public virtual Seccion Seccion { get; set; }

        public EstudianteSeccion()
        {
            Estado = EstadoEstudiante.Activo;
        }
    }
}
