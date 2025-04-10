using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.ViewComponents.LayoutViewComponent
{
    public class _LayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
