using KalenderTurizm.Core.Maps;
using KalenderTurizm.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.DataAccess.Concrete.EntityFramework.Maps
{
    public class TourMap:CoreMap<Tour>
    {
        public override void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TourName).IsRequired();
            builder.Property(x => x.TourName).HasMaxLength(50);
            builder.HasMany(x => x.PlaceToVisits).WithOne(x => x.Tour).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.TourCities).WithOne(x => x.Tour).HasForeignKey(x => x.TourId).OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
