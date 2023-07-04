using Apanvi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Apanvi.API.Context
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions options) 
            :base(options) { }
        public DbSet<Animal> Animals{ get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConnectionContext).Assembly);
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    } 
}

