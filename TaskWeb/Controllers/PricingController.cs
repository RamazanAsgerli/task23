using Microsoft.AspNetCore.Mvc;

namespace TaskWeb.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
