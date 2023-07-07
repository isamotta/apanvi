using Apanvi.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;

namespace Apanvi.API.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //var animals = new Animal();

            modelBuilder.Entity<Animal>()
                .HasData(
                    new Animal { Id = 1, Name = "Poppie" },
                    new Animal { Id = 2, Name = "Lola" },
                    new Animal { Id = 3, Name = "Bob" }


                );
            
        }
    }
}
