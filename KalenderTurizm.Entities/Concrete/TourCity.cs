﻿using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Concrete
{
    public class TourCity:IEntity
    {
        public int TourId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }


        public Tour Tour { get; set; }
        public City City { get; set; }
    }
}
