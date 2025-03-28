using Microsoft.AspNetCore.Mvc;

namespace EC.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptUiLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}