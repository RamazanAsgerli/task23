using Microsoft.AspNetCore.Mvc;

namespace TaskWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
