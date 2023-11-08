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
    public class TourManager : ITourService
    {
        public ITourDal _tourDal { get; set; }
        public IMapper _mapper { get; set; }

        public TourManager(ITourDal tourDal,IMapper mapper)
        {
            _tourDal = tourDal;
            _mapper = mapper;
        }
    }
}
