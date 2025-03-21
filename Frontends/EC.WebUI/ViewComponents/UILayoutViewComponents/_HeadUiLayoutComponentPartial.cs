using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _HeadUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}