﻿using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Dtos
{
    public class ShipDto:IDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ShipCompany { get; set; }
        public string ShipName { get; set; }
        public string Region { get; set; }
        public string TourDuration { get; set; }
        public DateTime Period { get; set; }
        public decimal Price { get; set; }
    }
}
