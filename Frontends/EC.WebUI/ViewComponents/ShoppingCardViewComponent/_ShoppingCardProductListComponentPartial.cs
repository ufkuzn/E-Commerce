using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ShoppingCardViewComponent
{
    public class _ShoppingCardProductListComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}