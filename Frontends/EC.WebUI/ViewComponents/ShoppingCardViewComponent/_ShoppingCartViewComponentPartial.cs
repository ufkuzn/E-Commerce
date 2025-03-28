using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ShoppingCardViewComponent
{
    public class _ShoppingCartViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}