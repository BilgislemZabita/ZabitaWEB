﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class PersonelMapping : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.ToTable("Personel")
            .HasKey(x => x.PersonelId);
            builder
           .HasIndex(b => b.PersonelId).IsUnique();
            builder.HasMany(b => b.Yetkis).WithOne(s => s.Personel).OnDelete(DeleteBehavior.Cascade);
            //builder.HasData(new Yetki {Name="user" });
        }
    }
}