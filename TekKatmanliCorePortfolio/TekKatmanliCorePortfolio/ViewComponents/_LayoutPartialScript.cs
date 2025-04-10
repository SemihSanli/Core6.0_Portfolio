using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.ViewComponents
{
    public class _LayoutPartialScript:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
