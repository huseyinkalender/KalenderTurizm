using KalenderTurizm.Core.DataAccess.EntityFramework;
using KalenderTurizm.DataAccess.Abstract;
using KalenderTurizm.DataAccess.Concrete.EntityFrameworkCore.Context;
using KalenderTurizm.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.DataAccess.Concrete
{
    public class PlaceToVisitDal : RepositoryBase<PlaceToVisit>, IPlaceToVisitDal
    {
        public PlaceToVisitDal(KalenderTurizmContext context) : base(context)
        {
        }
    }
}
