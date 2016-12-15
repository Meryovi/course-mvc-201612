using Proyecto1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto1
{
    public class DbConfig
    {
        public static void ConfigureDb()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ColegioDbContext>());
        }
    }
}