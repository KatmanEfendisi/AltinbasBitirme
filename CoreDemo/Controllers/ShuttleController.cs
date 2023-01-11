using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ShuttleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
