using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}