using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjemploCliente.DAL
{
    public class EjemploDb : DbContext
    {
        public EjemploDb() : base("ConStr")
        {

        }

        public DbSet<Models.Clientes> Cliente { get; set; }

    }
}