using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto1.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Matrícula")]
        [StringLength(10, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Apellidos { get; set; }

        [StringLength(800, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Observaciones { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Fecha de Matriculación")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaMatriculacion { get; set; }
    }
}