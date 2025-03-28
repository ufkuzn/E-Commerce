using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailImageSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}