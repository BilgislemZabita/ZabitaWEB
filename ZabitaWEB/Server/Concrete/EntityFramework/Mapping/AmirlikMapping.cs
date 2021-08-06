using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    internal class AmirlikMapping : IEntityTypeConfiguration<Amirlik>
    {
        public void Configure(EntityTypeBuilder<Amirlik> builder)
        {
            builder.ToTable("Amirliks")
            .HasKey(x => x.AmirlikID);

            builder
              .HasIndex(b => b.AmirlikSeriNo).IsUnique();

            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoAmirlik).OnDelete(DeleteBehavior.Cascade);
            
            //builder
            //   .HasMany(m => m.IsTipleri)
            //   .WithOne(m => m.IsTipiAmirlik).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(m => m.Demirbaslar)
                .WithOne(m => m.DemirbasAmirlik);
            builder
               .HasMany(m => m.Personeller)
               .WithOne(m => m.PersonelAmirlik);

            builder
                .HasOne(p => p.AmirlikMudurluk)
                .WithMany(c => c.Amirlikler).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(c => c.Odalar)
                .WithOne(z => z.OdaAmirlik).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(v => v.YerleskeBakimOnarim)
                .WithOne(a => a.YerleskeBakimOnarimAmirlik).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(a => a.YerleskeIklimlendirme)
                .WithOne(x => x.YerleskeIklimlendirmeAmirlik).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(x => x.YerleskeTeknikBilgiler)
                .WithOne(z => z.YerleskeTeknikBilgilerAmirlik).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(s => s.Sarf)
                .WithOne(d => d.SarfAmirlik);
        }
    }
}