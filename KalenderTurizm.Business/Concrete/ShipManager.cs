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
    public class ShipManager : IShipService
    {
        public IShipDal _shipDal { get; set; }
        public IMapper _mapper { get; set; }

        public ShipManager(IShipDal shipDal,IMapper mapper)
        {
            _shipDal = shipDal;
            _mapper = mapper;
        }
    }
}
