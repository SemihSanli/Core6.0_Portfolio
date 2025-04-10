using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.ViewComponents
{
    public class _HeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
