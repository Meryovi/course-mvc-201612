using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es {1}")]
        public string NombreUsuario { get; set; }

        public UsuarioNivel Nivel { get; set; }

        public bool Activo { get; set; }

        public Usuario()
        {
            Activo = true;
            Nivel = UsuarioNivel.Administrador;
        }
    }
}
