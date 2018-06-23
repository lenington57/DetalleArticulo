using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegistroDetalle.Entidades;

namespace RegistroDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        public DbSet<Personas> Personas { get; set; }

        public DbSet<Cotizaciones> Cotizaciones { get; set; }


        public Contexto() : base("ConStr")
        {

        }
    }
}
