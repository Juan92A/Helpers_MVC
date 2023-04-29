using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposDbContext : DbContext
    {
       
            public equiposDbContext(DbContextOptions options) : base(options)
            {

            }


        public DbSet<Marcas> marcas { get; set; }
      public DbSet<Equipos> equipos { get; set; } 
        public DbSet<TipoEquipos> tipo_equipo { get; set; }
        public DbSet<EstadosEquipos> estados_equipo { get; set; }
    }
}
