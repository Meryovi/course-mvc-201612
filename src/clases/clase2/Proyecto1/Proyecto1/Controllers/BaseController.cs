using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto1.Controllers
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
            dbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}