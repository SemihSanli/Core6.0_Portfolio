using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
