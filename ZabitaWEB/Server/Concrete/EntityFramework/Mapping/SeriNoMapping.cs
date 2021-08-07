using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace ZabitaWEB.Server.Concrete.EntityFramework.Mapping
{
    public class SeriNoMapping : IEntityTypeConfiguration<SeriNo>
    {
        public void Configure(EntityTypeBuilder<SeriNo> builder)
        {

            builder.ToTable("SeriNo")
            .HasKey(x => x.SeriNoId);


            builder
          .Property(c => c.SeriNoId)
          .ValueGeneratedNever();
        }
    }
}
