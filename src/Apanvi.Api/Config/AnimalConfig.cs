using Apanvi.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Apanvi.API.Config
{
    public class AnimalConfig : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable(nameof(Animal));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired();

            builder.Property(x => x.Age);

            builder.Property(x => x.Genre);

            builder.Property(x => x.Species);

            builder.Property(x => x.Size);

            builder.Property(x => x.Image);

            builder.Property(x => x.Description);


        }
    }
}
