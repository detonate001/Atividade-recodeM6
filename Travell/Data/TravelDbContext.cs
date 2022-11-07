using Microsoft.EntityFrameworkCore;
using Travell.Models;

namespace Travell.Data
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions<TravelDbContext> options)
            : base(options)
        {

        }


        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<DestinoModel> Destino { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
