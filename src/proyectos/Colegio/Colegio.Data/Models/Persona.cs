using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Colegio.Models
{
    public abstract class Persona
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Apellidos { get; set; }

        [EmailAddress(ErrorMessage = "El campo {0} no es un correo valido")]
        [StringLength(80, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string Correo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
    }
}