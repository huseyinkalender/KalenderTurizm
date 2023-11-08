using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Dtos
{
    public class PlaceToVisitDto:IDto
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int CategoryId { get; set; }
        public string PlaceToVisitName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string TypeOfTransportation { get; set; }
        public string TourDuration { get; set; }
        public string StartingPoint { get; set; }
        public string Period { get; set; }
        public string Image { get; set; }
    }
}
