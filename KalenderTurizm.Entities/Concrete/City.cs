using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Concrete
{
    public  class City:IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; } 
        public bool IsDeleted { get; set; } 

     
      
        public ICollection<TourCity> TourCities { get; set; }

    }
}
