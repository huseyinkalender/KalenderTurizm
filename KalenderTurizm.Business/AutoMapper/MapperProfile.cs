using AutoMapper;
using KalenderTurizm.Entities.Concrete;
using KalenderTurizm.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Business.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, RegisterDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Tour,TourDto>().ReverseMap();
            CreateMap<City,CityDto>().ReverseMap();
            CreateMap<PlaceToVisit, PlaceToVisitDto>().ReverseMap();
            CreateMap<Ship, ShipDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<FlightTicket, FlightTicketDto>().ReverseMap();
            CreateMap<TourCity, TourCityDto>().ReverseMap();
            
        }
    }
}
