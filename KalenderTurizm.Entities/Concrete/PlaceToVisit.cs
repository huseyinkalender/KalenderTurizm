using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Concrete
{
    public class PlaceToVisit:IEntity
    {
        public PlaceToVisit()
        {
            DateOfUpdate = DateTime.Now;
        }

 
        public int Id { get; set; }
        public int TourId { get; set; }
        public int CategoryId { get; set; }
        public string PlacesToVisitName { get; set; } 
        public decimal Price { get; set; } 
        public string Description { get; set; }
        private DateTime DateOfUpdate { get; set; }
        public bool IsDeleted { get; set; }
        public string TypeOfTransportation { get; set; } 
        public string TourDuration { get; set; } 
        public string StartingPoint { get; set; } 
        public string Period { get; set; } 
        public string Image { get; set; } 


       
      
        public virtual Tour Tour { get; set; } 
        public virtual Category Category { get; set; } 
    }
}
