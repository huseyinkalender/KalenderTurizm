using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalenderTurizm.Core.Entities;

namespace KalenderTurizm.Entities.Concrete
{
    public class Tour:IEntity
    {
        public Tour() // Yapıcı(Constructor) Metot
        {
            DateOfUpdate = DateTime.Now;

        }

     
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string TourName { get; set; } 
        private DateTime DateOfUpdate { get; set; } 
        public bool IsDeleted { get; set; } 


        public virtual Category Category { get; set; } 

        public ICollection<PlaceToVisit> PlaceToVisits { get; set; }
        public ICollection<TourCity> TourCities { get; set; }

    }
}
