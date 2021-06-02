using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    internal class YerleskeBakimOnarimMapping : IEntityTypeConfiguration<YerleskeBakimOnarim>
    {
        public void Configure(EntityTypeBuilder<YerleskeBakimOnarim> builder)
        {
            builder.ToTable("yerleskebakimonarims")
            .HasKey(x => x.YerleskeBakimOnarimId);

            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoYerleskeBakimOnarim)
               .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(m => m.YerleskeBakimOnarimYerleske)
                .WithMany(m => m.YerleskeBakimOnarim);

            builder
                .HasOne(m => m.YerleskeBakimOnarimMudurluk)
                .WithMany(m => m.YerleskeBakimOnarim);

            builder
                .HasOne(m => m.YerleskeBakimOnarimAmirlik)
                .WithMany(m => m.YerleskeBakimOnarim);

            builder
                .HasOne(m => m.YerleskeBakimOnarimOda)
                .WithMany(m => m.YerleskeBakimOnarim);
        }
    }
}