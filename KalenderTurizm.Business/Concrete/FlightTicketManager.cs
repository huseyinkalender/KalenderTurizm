using AutoMapper;
using KalenderTurizm.Business.Abstract;
using KalenderTurizm.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Business.Concrete
{
    public class FlightTicketManager : IFlightTicketService
    {
        public IFlightTicketDal _flightTicketDal { get; set; }
        public IMapper _mapper { get; set; }

        public FlightTicketManager(IFlightTicketDal flightTicketDal,IMapper mapper)
        {
            _flightTicketDal = flightTicketDal;
            _mapper = mapper;
        }
    }
}
