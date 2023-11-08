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
    public class PlaceToVisitManager : IPlaceToVisitService
    {
        public IPlaceToVisitDal _placeToVisitDal { get; set; }
        public IMapper _mapper { get; set; }

        public PlaceToVisitManager(IPlaceToVisitDal placeToVisitDal,IMapper mapper)
        {
            _placeToVisitDal = placeToVisitDal;
            _mapper = mapper;
        }
    }
}
