using GestionOptica.Models;
using Microsoft.EntityFrameworkCore;


namespace GestionOptica.Data
{
    public class MyClientesContext: DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<ObraSocial> ObraSocial { get; set; }
        public DbSet<Planes> Planes { get; set; }
        public DbSet<EstadoCliente> EstadoCliente { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=GestionOpticaWeb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
