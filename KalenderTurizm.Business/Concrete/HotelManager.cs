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
    public class HotelManager : IHotelService
    {
        public IHotelDal _hotelDal { get; set; }
        public IMapper _mapper { get; set; }

        public HotelManager(IHotelDal hotelDal,IMapper mapper)
        {
            _hotelDal = hotelDal;
            _mapper = mapper;
        }
    }
}
