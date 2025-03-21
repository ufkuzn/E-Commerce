using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _TopbarUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}