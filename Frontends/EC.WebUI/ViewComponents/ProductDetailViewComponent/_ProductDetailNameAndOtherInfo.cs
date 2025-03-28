using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailNameAndOtherInfo:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}