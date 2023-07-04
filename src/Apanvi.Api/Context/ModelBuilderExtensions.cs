using Apanvi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Apanvi.API.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var animals = new Animal();
        }
    }
}
