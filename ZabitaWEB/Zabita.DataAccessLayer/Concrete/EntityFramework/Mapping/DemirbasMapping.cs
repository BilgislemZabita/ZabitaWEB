using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    class DemirbasMapping : IEntityTypeConfiguration<Demirbas>
    {
        public void Configure(EntityTypeBuilder<Demirbas> builder)
        {
            builder.ToTable("Demirbases")
            .HasKey(x => new { x.DemirbasId });



            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoDemirbas);

            builder
                .HasOne(m => m.DemirbasYerleske)
                .WithMany(m => m.Demirbaslar);

            builder
                .HasOne(m => m.DemirbasMudurluk)
                .WithMany(m => m.Demirbaslar);

            builder
                .HasOne(m => m.DemirbasAmirlik)
                .WithMany(m => m.Demirbaslar);

            builder
                .HasOne(m => m.DemirbasOda)
                .WithMany(m => m.Demirbaslar);

            builder
                .HasOne(m => m.DemirbasPersonel)
                .WithMany(m => m.Demirbaslar);
        }
    }
}
