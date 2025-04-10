using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.ViewComponents
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
