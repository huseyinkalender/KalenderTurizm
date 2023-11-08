using AutoMapper;
using KalenderTurizm.Business.Abstract;
using KalenderTurizm.DataAccess.Abstract;
using KalenderTurizm.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public ICategoryDal _categoryDal { get; set; }
        public IMapper _mapper { get; set; }

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

      
    }
}
