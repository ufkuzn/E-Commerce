using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListPagginationComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}