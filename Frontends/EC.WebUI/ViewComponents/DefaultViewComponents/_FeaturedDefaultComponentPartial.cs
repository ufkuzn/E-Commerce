using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.DefaultViewComponents
{
    public class _FeaturedDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}