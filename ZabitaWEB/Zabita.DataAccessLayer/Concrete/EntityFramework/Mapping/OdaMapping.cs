using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    internal class OdaMapping : IEntityTypeConfiguration<Oda>
    {
        public void Configure(EntityTypeBuilder<Oda> builder)
        {
            builder.ToTable("Odas")
                                   .HasKey(x => x.OdaId);

            builder
              .HasIndex(b => b.OdaSeriNo).IsUnique();
            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoOda).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(p => p.OdaAmirlik)
                .WithMany(c => c.Odalar).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(p => p.OdaMudurluk)
                .WithMany(c => c.Odalar).OnDelete(DeleteBehavior.Cascade);

            builder
         .HasMany(m => m.Personeller)
         .WithOne(m => m.PersonelOda);
            builder
                .HasMany(m => m.Demirbaslar)
                .WithOne(m => m.DemirbasOda);

            builder
                .HasMany(s => s.Sarf)
                .WithOne(d => d.SarfOda);
            builder
                .HasMany(x => x.YerleskeBakimOnarim)
                .WithOne(x => x.YerleskeBakimOnarimOda).OnDelete(DeleteBehavior.Cascade);
            builder
               .HasMany(x => x.YerleskeTeknikBilgiler)
               .WithOne(x => x.YerleskeTeknikBilgilerOda).OnDelete(DeleteBehavior.Cascade);
            builder
               .HasMany(x => x.YerleskeIklimlendirme)
               .WithOne(x => x.YerleskeIklimlendirmeOda).OnDelete(DeleteBehavior.Cascade);
        }
    }
}