using KalenderTurizm.DataAccess.Concrete.EntityFramework.Maps;
using KalenderTurizm.DataAccess.Concrete.EntityFrameworkCore.Maps;
using KalenderTurizm.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class KalenderTurizmContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Veri tabanı bağlantı cümlemiz
            optionsBuilder.UseSqlServer(@"Server=localhost;Initial Catalog=KalenderTurizmDb;
            Trusted_Connection=true;TrustServerCertificate=True");
           
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TourCity>().HasKey(x=> new {x.TourId,x.CityId});
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new CityMap());
            builder.ApplyConfiguration(new TourMap());
            builder.ApplyConfiguration(new PlaceToVisitMap());
            builder.ApplyConfiguration(new HotelMap());
            builder.ApplyConfiguration(new ShipMap());
            builder.ApplyConfiguration(new FlightTicketMap());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<FlightTicket> FlightTickets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PlaceToVisit> PlaceToVisits { get; set; }
        public DbSet<TourCity> TourCities { get; set; }
    }
}
