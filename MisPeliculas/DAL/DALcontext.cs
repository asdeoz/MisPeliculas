using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MisPeliculas
{
    public class DALcontext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
