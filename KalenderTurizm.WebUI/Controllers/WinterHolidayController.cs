using Microsoft.AspNetCore.Mvc;

namespace KalenderTurizm.WebUI.Controllers
{
    public class WinterHolidayController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
