using Colegio.ActionFilters;
using Colegio.Models;
using System.Web;
using System.Web.Mvc;

namespace Colegio
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ValidarAccesoFilter(UsuarioNivel.Usuario));
        }
    }
}
