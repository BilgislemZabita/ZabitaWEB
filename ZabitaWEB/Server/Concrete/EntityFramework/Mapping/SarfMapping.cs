using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    class SarfMapping : IEntityTypeConfiguration<Sarf>
    {
        public void Configure(EntityTypeBuilder<Sarf> builder)
        {
            builder.ToTable("Sarfs")
            .HasKey(x => x.SarfId);

            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoSarf);
            builder
                .HasOne(m => m.SarfYerleske)
                .WithMany(m => m.Sarf);

            builder
                .HasOne(m => m.SarfMudurluk)
                .WithMany(m => m.Sarf);

            builder
                .HasOne(m => m.SarfAmirlik)
                .WithMany(m => m.Sarf);

            builder
                .HasOne(m => m.SarfOda)
                .WithMany(m => m.Sarf);

            builder
                .HasOne(m => m.SarfPersonel)
                .WithMany(m => m.Sarf);
        }
    }
}
