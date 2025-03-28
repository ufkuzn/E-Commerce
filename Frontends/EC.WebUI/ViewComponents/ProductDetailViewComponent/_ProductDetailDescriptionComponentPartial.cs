using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailDescriptionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}