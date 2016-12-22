using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Models
{
    [Table("Secciones")]
    public class Seccion
    {
        public int Id { get; set; }

        [Display(Name = "Profesor")]
        public int ProfesorId { get; set; }

        [Display(Name = "Materia")]
        public int MateriaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(80, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Ubicacion { get; set; }

        [Display(Name = "Max. de Estudiantes")]
        public int? MaximoEstudiantes { get; set; }

        [StringLength(500, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Observaciones { get; set; }

        public bool Activa { get; set; }

        [Display(Name = "Fecha de Registro")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        [ForeignKey("ProfesorId")]
        public virtual Profesor Profesor { get; set; }

        [ForeignKey("MateriaId")]
        public virtual Materia Materia { get; set; }

        public Seccion()
        {
            Activa = true;
        }
    }
}
