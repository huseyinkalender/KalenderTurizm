using KalenderTurizm.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Dtos
{
    public class FlightTicketDto:IDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string FlightCompany { get; set; } // Uçak Firması
        public string DepartureTime { get; set; } // Kalkış Saati
        public string FlightTime { get; set; } // Uçuş Süresi
        public string TransferStatus { get; set; } // Aktarma Durumu
        public string LuggageStatus { get; set; } // Bagaj Durumu
        public decimal Price { get; set; } // Fiyat
    }
}
