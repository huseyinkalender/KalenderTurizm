using KalenderTurizm.Business.Abstract;
using KalenderTurizm.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthService _authService;
        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _authService.Login(loginDto);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "KalenderTurizm");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var result = await _authService.Register(registerDto);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}
