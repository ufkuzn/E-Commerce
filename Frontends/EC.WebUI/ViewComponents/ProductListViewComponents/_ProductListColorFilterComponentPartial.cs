using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListColorFilterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}