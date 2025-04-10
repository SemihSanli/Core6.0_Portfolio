using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.ViewComponents.LayoutViewComponent
{
    public class _LayoutPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
