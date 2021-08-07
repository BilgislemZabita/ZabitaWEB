using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Concrete.EntityFramework.Mapping
{
    internal class YerleskeMapping : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Yerleske>
    {
        public void Configure(EntityTypeBuilder<Yerleske> builder)
        {
            builder.ToTable("Yerleskes")
                        .HasKey(x => x.YerleskeId);

            builder
                .HasIndex(b => b.YerleskeSeriNo).IsUnique();

            builder
                .HasMany(m => m.Demirbaslar)
                .WithOne(m => m.DemirbasYerleske);
            builder
                .HasMany(m => m.Fotolar)
                .WithOne(m => m.FotoYerleske).OnDelete(DeleteBehavior.Cascade);

            builder
         .HasMany(m => m.Personeller)
         .WithOne(m => m.PersonelYerleske);
            builder
                .HasMany(s => s.Sarf)
                .WithOne(d => d.SarfYerleske);
            builder

                .HasMany(x => x.YerleskeBakimOnarim)
                .WithOne(x => x.YerleskeBakimOnarimYerleske).OnDelete(DeleteBehavior.Cascade);

            builder
               .HasMany(x => x.YerleskeTeknikBilgiler)
               .WithOne(x => x.YerleskeTeknikBilgilerYerleske).OnDelete(DeleteBehavior.Cascade);
            builder
               .HasMany(x => x.YerleskeIklimlendirme)
               .WithOne(x => x.YerleskeIklimlendirmeYerleske).OnDelete(DeleteBehavior.Cascade);
        }
    }
}