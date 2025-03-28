using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailInformationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}