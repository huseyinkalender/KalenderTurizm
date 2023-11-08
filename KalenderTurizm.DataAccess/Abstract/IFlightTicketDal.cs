using KalenderTurizm.Core.DataAccess.EntityFramework;
using KalenderTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.DataAccess.Abstract
{
    public interface IFlightTicketDal:IRepository<FlightTicket>
    {

    }
}
