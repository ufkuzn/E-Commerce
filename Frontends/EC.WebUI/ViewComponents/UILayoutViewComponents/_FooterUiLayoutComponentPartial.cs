using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}