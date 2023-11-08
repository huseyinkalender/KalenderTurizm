using KalenderTurizm.Core.Maps;
using KalenderTurizm.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.DataAccess.Concrete.EntityFrameworkCore.Maps
{
    public class ShipMap:CoreMap<Ship>
    {
        public override void Configure(EntityTypeBuilder<Ship> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.ShipCompany).IsRequired();
            builder.Property(x => x.ShipCompany).HasMaxLength(50);
            builder.Property(x => x.ShipName).IsRequired();
            builder.Property(x => x.ShipName).HasMaxLength(50);
            builder.Property(x => x.Region).IsRequired();
            builder.Property(x => x.Region).HasMaxLength(50);
            builder.Property(x => x.TourDuration).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Period).IsRequired();
      

            base.Configure(builder);
        }
    }
}
