using Microsoft.AspNetCore.Mvc;

namespace TekKatmanliCorePortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
