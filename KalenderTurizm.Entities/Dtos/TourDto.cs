using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Dtos
{
    public class TourDto:IDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string TourName { get; set; }
    }
}
