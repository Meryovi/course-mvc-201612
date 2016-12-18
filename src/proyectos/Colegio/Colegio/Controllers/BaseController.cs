using Colegio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colegio.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ColegioDbContext dbContext;

        public BaseController()
        {
            dbContext = new ColegioDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}