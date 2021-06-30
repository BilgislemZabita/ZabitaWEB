using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabita.Entities.Concrete;

namespace Zabita.DataAccessLayer.Concrete.EntityFramework.Mapping
{
    public class IsTipleriMapping : IEntityTypeConfiguration<IsTipleri>
    {
        public void Configure(EntityTypeBuilder<IsTipleri> builder)
        {
            builder.ToTable("IsTipleris")
            .HasKey(x => x.IsId );



           /* builder
               .HasOne(m => m.IsTipiAmirlik)
               .WithMany(m => m.IsTipleri);
            {
            }*/
        }
    }
}
