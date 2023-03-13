using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BiletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
