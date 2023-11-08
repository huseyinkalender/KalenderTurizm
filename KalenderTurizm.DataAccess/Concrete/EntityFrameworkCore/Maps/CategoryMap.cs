using KalenderTurizm.Core.Maps;
using KalenderTurizm.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.DataAccess.Concrete.EntityFramework.Maps
{
    public class CategoryMap:CoreMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).IsRequired();
            builder.Property(x => x.CategoryName).HasMaxLength(50);
            builder.HasMany(x => x.Tours).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.PlaceToVisits).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.FlighTickets).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.Hotels).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasMany(x => x.Ships).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.ClientSetNull);

            base.Configure(builder);
        }
    }
}
