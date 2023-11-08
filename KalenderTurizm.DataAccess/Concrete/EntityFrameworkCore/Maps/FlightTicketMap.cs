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
    public class FlightTicketMap:CoreMap<FlightTicket>
    {
        public override void Configure(EntityTypeBuilder<FlightTicket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FlightCompany).IsRequired();
            builder.Property(x=>x.FlightCompany).HasMaxLength(50);
            builder.Property(x=>x.DepartureTime).IsRequired();
            builder.Property(x=>x.FlightTime).IsRequired();
            builder.Property(x=>x.TransferStatus).IsRequired();
            builder.Property(x => x.TransferStatus).HasMaxLength(50);
            builder.Property(x => x.LuggageStatus).IsRequired();
            builder.Property(x => x.LuggageStatus).HasMaxLength(50);
            builder.Property(x=>x.Price).IsRequired();

            base.Configure(builder);
        }
    }
}
