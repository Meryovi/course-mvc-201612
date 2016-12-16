using Colegio.DataAccess.Migrations;
using Colegio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Colegio
{
    public class DbConfig
    {
        public static void ConfigureDb()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ColegioDbContext, Configuration>());
        }
    }
}