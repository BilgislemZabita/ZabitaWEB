using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class TalepMapping : IEntityTypeConfiguration<Talep>
    {
        public void Configure(EntityTypeBuilder<Talep> builder)
        {
            builder.ToTable("Talep")
            .HasKey(x => x.TalepId);

            builder
               .HasOne(m => m.TalebiIsteyenPersonel)
               .WithMany(m => m.Taleps); 
            builder
               .HasMany(m => m.Fotolar)
               .WithOne(m => m.FotoTalep).OnDelete(DeleteBehavior.Cascade);

        }
    }
}