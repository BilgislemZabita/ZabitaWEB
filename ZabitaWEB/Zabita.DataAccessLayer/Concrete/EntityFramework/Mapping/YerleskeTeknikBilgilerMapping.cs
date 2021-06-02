using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class YerleskeTeknikBilgilerMapping : IEntityTypeConfiguration<YerleskeTeknikBilgiler>
    {
        public void Configure(EntityTypeBuilder<YerleskeTeknikBilgiler> builder)
        {
            builder.ToTable("yerleskeTeknikBilgiler")
               .HasKey(x => x.YerleskeTeknikBilgilerId);

            builder.Property(b => b.MerkeziYanginSondurme).HasMaxLength(5);
            builder.Property(b => b.AcilCikis).HasMaxLength(5);
            builder.Property(b => b.EngelliErisimi).HasMaxLength(5);
            builder.Property(b => b.Asansör).HasMaxLength(5);

            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoYerleskeTeknikBilgiler)
               .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(m => m.YerleskeTeknikBilgilerYerleske)
                .WithMany(m => m.YerleskeTeknikBilgiler);

            builder
                .HasOne(m => m.YerleskeTeknikBilgilerMudurluk)
                .WithMany(m => m.YerleskeTeknikBilgiler);

            builder
                .HasOne(m => m.YerleskeTeknikBilgilerAmirlik)
                .WithMany(m => m.YerleskeTeknikBilgiler);

            builder
                .HasOne(m => m.YerleskeTeknikBilgilerOda)
                .WithMany(m => m.YerleskeTeknikBilgiler);
        }
    }
}