using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.DefaultViewComponents
{
    public class _SpecialOfferComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}