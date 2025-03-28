using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}