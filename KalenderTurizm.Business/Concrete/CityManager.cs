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
    public class CityManager : ICityService
    {
        public ICityDal _cityDal { get; set; }
        public IMapper _mapper { get; set; }

        public CityManager(ICityDal cityDal,IMapper mapper)
        {
            _cityDal = cityDal;
            _mapper = mapper;
        }
    }
}
