using KalenderTurizm.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Entities.Concrete
{
    public class AppRole: IdentityRole<int>, IEntity
    {
        public bool IsDeleted { get; set; }
    }
}
