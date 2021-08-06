using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class TakvimMapping : IEntityTypeConfiguration<Takvim>
    {
        public void Configure(EntityTypeBuilder<Takvim> builder)
        {
            builder.ToTable("Takvims")
         .HasKey(x => x.TakvimId);
            builder
              .HasMany(c => c.TakvimDetaylaris)
              .WithOne(z => z.TakvimTakvimDetaylari).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
