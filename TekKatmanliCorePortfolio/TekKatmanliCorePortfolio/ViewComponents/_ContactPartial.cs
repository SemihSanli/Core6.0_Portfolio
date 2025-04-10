using Microsoft.AspNetCore.Mvc;
using TekKatmanliCorePortfolio.DAL.Context;

namespace TekKatmanliCorePortfolio.ViewComponents
{
    public class _ContactPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }
    }
}
