using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zabita.Entities.Concrete;
namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    class TalepAltSonucuMapping : IEntityTypeConfiguration<TalepAltSonucu>
    {
        public void Configure(EntityTypeBuilder<TalepAltSonucu> builder)
        {
            builder.ToTable("TalepAltSonucu")
            .HasKey(x => x.TalepAltSonucuId);

            builder.HasOne(s => s.Personel).WithMany(s => s.TalepAltSonucus);
            builder.HasOne(s => s.Amirlik).WithMany(s => s.TalepAltSonucus);


            //builder.HasOne(s => s.Taleptalepaltsonucu).WithMany(s=>s.TalepAltSonucus);
          
               

        }
    }
}

