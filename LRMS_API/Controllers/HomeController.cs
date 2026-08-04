using Microsoft.AspNetCore.Mvc;

namespace LRMS_API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Login/Index.cshtml");
        }
    }
}