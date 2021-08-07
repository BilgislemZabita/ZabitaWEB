using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Concrete.EntityFramework.Mapping
{
    public class FotoMapping : IEntityTypeConfiguration<Foto>
    {
        public void Configure(EntityTypeBuilder<Foto> builder)
        {
            builder.ToTable("Fotolar")
                                              .HasKey(x => x.FotoId);

            builder
                .HasOne(p => p.FotoOda)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoAmirlik)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoMudurluk)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoYerleske)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoDemirbas)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoSarf)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoPersonel)
                    .WithMany(c => c.Fotolar).OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoYerleskeBakimOnarim)
                    .WithMany(c => c.Fotolar)
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoYerleskeIklimlendirme)
                    .WithMany(c => c.Fotolar)
                    .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.FotoYerleskeTeknikBilgiler)
                    .WithMany(c => c.Fotolar)
                    .OnDelete(DeleteBehavior.Cascade); 
            builder
                .HasOne(p => p.FotoTalep)
                    .WithMany(c => c.Fotolar)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}