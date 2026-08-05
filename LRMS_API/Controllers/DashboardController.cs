using Microsoft.AspNetCore.Mvc;

namespace LRMS_API.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}