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
    public class CityMap:CoreMap<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CityName).IsRequired();
            builder.Property(x => x.CityName).HasMaxLength(50);
            builder.HasMany(x => x.TourCities).WithOne(x => x.City).HasForeignKey(x => x.CityId).OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
