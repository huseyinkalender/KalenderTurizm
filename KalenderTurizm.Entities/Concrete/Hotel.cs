using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Concrete
{
    public class Hotel : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }
        public string HotelName { get; set; }
        public string AccommodationType { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string NumberOfRooms { get; set; }
        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

        public City City { get; set; }
        public Category Category { get; set; }
    }
}
