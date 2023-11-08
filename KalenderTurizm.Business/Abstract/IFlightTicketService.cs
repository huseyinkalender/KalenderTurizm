using AutoMapper;
using KalenderTurizm.DataAccess.Abstract;
using KalenderTurizm.DataAccess.Concrete;
using KalenderTurizm.Entities.Concrete;
using KalenderTurizm.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Business.Abstract
{
    public interface IFlightTicketService
    {
        public IFlightTicketDal _flightTicketDal { get; set; }
        public IMapper _mapper { get; set; }    

        public FlightTicket FlightTicketDtoConvert(FlightTicketDto flightTicketDto)
        {
            return _mapper.Map<FlightTicket>(flightTicketDto);
        }

        async Task<FlightTicketDto> GetFlightTicketAsync(int id)
        {
            FlightTicket flightTicket = await _flightTicketDal.GetAsync(x => x.Id == id);
            return _mapper.Map<FlightTicketDto>(flightTicket);
        }
        async Task<List<FlightTicketDto>> GetAllFlightTicketAsync()
        {
            List<FlightTicket> flightTickets = await _flightTicketDal.GetAllAsync();
            List<FlightTicketDto> flightTicketDtos = new List<FlightTicketDto>();
            foreach (FlightTicket flight in flightTickets)
            {
                FlightTicketDto flightTicketDto = _mapper.Map<FlightTicketDto>(flight);
               flightTicketDtos.Add(flightTicketDto);
            }
            return flightTicketDtos;
        }

        async Task<bool> AddFlightTicketAsync(FlightTicketDto flightTicketDto)
        {
           FlightTicket flightTicket = FlightTicketDtoConvert(flightTicketDto);
            int response = await _flightTicketDal.AddAsync(flightTicket);
            return response > 0;
        }

        async Task<bool> UpdateFlightTicketAsync(FlightTicketDto flightTicketDto)
        {
            FlightTicket flightTicket = FlightTicketDtoConvert(flightTicketDto);
            int response = await _flightTicketDal.UpdateAsync(flightTicket);
            return response > 0;
        }

        async Task<bool> DeleteFlightTicketAsync(FlightTicketDto flightTicketDto)
        {
            FlightTicket flightTicket = FlightTicketDtoConvert(flightTicketDto);
            int response = await _flightTicketDal.DeleteAsync(flightTicket);
            return response > 0;
        }
    }
}
