using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}