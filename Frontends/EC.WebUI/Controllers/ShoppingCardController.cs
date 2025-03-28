using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.Controllers
{
    public class ShoppingCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}