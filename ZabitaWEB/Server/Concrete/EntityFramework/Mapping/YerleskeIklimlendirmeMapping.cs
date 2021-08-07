using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Concrete.EntityFramework.Mapping
{
    internal class YerleskeIklimlendirmeMapping : IEntityTypeConfiguration<YerleskeIklimlendirme>
    {
        public void Configure(EntityTypeBuilder<YerleskeIklimlendirme> builder)
        {
            builder.ToTable("yerleskeiklimlendirmes")
            .HasKey(x => x.YerleskeIklimlendirmeId);

            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoYerleskeIklimlendirme)
            .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(m => m.YerleskeIklimlendirmeYerleske)
                .WithMany(m => m.YerleskeIklimlendirme);

            builder
                .HasOne(m => m.YerleskeIklimlendirmeMudurluk)
                .WithMany(m => m.YerleskeIklimlendirme);

            builder
                .HasOne(m => m.YerleskeIklimlendirmeAmirlik)
                .WithMany(m => m.YerleskeIklimlendirme);

            builder
                .HasOne(m => m.YerleskeIklimlendirmeOda)
                .WithMany(m => m.YerleskeIklimlendirme);
        }
    }
}