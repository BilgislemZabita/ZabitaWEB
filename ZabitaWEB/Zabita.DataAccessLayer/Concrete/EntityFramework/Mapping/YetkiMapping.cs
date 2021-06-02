using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class YetkiMapping : IEntityTypeConfiguration<Yetki>
    {
        public void Configure(EntityTypeBuilder<Yetki> builder)
        {
            builder.ToTable("Yetki").HasKey(x => x.YetkiId);

            builder.HasOne(m => m.Modul).WithMany(m => m.YetkiModuller);
        }
    }
}