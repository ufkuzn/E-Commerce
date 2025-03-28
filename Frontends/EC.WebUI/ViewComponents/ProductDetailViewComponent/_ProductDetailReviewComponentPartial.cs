using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailReviewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}