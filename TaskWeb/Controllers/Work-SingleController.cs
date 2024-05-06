using Microsoft.AspNetCore.Mvc;

namespace TaskWeb.Controllers
{
    public class Work_SingleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
