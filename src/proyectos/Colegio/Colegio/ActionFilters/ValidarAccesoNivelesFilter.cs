using Colegio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colegio.ActionFilters
{
    public class ValidarAccesoNivelesFilter : ActionFilterAttribute
    {
        private readonly UsuarioNivel[] nivelesPermitidos;

        public ValidarAccesoNivelesFilter(params UsuarioNivel[] niveles)
        {
            nivelesPermitidos = niveles;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            using (var dbContext = new ColegioDbContext())
            {
                string usrConectado = filterContext.HttpContext.User.Identity.Name;

                var usuario = dbContext.Usuarios
                    .FirstOrDefault(u => u.NombreUsuario == usrConectado);

                if (usuario == null || nivelesPermitidos.Contains(usuario.Nivel))
                    filterContext.Result = new RedirectResult("http://google.com");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}