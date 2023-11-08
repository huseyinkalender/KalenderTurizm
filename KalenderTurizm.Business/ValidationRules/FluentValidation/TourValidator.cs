using FluentValidation;
using KalenderTurizm.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Business.ValidationRules.FluentValidation
{
    public class TourValidator:AbstractValidator<Tour>
    {
        public TourValidator()
        {
            
        }
    }
}
