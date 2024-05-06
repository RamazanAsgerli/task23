using Microsoft.AspNetCore.Mvc;

namespace TaskWeb.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
