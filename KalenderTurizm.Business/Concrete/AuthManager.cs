using AutoMapper;
using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalenderTurizm.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        public UserManager<AppUser> _userManager { get; set; }
        public RoleManager<AppRole> _roleManager { get; set; }
        public SignInManager<AppUser> _signInManager { get; set; }
        public IMapper _mapper { get; set; }

        public AuthManager(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }
    }
}
