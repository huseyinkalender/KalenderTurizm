using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Concrete
{
    public class Category:IEntity
    {
     
        public int Id { get; set; }
        public string CategoryName { get; set; } 
        public bool IsDeleted { get; set; } 

       
        public ICollection<Tour> Tours { get; set; } 
        public ICollection<PlaceToVisit> PlaceToVisits { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Ship> Ships { get; set; }
        public ICollection<FlightTicket> FlighTickets { get; set; }

    }
}
