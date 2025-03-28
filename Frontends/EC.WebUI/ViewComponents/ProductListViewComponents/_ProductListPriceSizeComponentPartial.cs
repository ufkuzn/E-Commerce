using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListPriceSizeComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}