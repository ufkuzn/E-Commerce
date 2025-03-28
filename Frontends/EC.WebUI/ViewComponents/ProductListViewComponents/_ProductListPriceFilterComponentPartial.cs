using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListPriceFilterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}