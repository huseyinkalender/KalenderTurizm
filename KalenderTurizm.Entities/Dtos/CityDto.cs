using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Dtos
{
    public class CityDto:IDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
