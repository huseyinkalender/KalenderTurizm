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
    public class HotelMap:CoreMap<Hotel>
    {
        public override void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.HotelName).IsRequired();
            builder.Property(x => x.HotelName).HasMaxLength(500);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x=>x.AccommodationType).IsRequired();
            builder.Property(x=>x.AccommodationType).HasMaxLength(500);
            builder.Property(x=>x.NumberOfRooms).IsRequired();
            builder.Property(x=>x.Price).IsRequired();

            base.Configure(builder);
        }
    }
}
