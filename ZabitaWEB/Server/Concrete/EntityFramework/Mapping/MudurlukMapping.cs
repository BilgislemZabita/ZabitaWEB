using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Concrete.EntityFramework.Mapping
{
    internal class MudurlukMapping : IEntityTypeConfiguration<Mudurluk>
    {
        public void Configure(EntityTypeBuilder<Mudurluk> builder)
        {
            builder.ToTable("Mudurluks")
           .HasKey(x => x.MudurlukId);

            builder
              .HasIndex(b => b.MudurlukSeriNo).IsUnique();
            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoMudurluk).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(c => c.Odalar)
                .WithOne(z => z.OdaMudurluk).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(c => c.Amirlikler)
                .WithOne(z => z.AmirlikMudurluk).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(v => v.YerleskeBakimOnarim)
                .WithOne(a => a.YerleskeBakimOnarimMudurluk).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(a => a.YerleskeIklimlendirme)
                .WithOne(x => x.YerleskeIklimlendirmeMudurluk).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(x => x.YerleskeTeknikBilgiler)
                .WithOne(z => z.YerleskeTeknikBilgilerMudurluk).OnDelete(DeleteBehavior.Cascade);
            builder
                .HasMany(s => s.Sarf)
                .WithOne(d => d.SarfMudurluk);
            builder
         .HasMany(m => m.Personeller)
         .WithOne(m => m.PersonelMudurluk);
            builder
            .HasMany(m => m.Demirbaslar)
            .WithOne(m => m.DemirbasMudurluk);
        }
    }
}