using Apanvi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Apanvi.API.Context
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions options) 
            :base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConnectionContext).Assembly);
            base.OnModelCreating(modelBuilder);

            modelBuilder.UseSerialColumns();
            modelBuilder.Seed();
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<User> Users { get; set; }
    } 
}

