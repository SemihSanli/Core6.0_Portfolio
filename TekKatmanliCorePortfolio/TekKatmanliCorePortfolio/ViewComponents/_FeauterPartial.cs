using Microsoft.AspNetCore.Mvc;
using TekKatmanliCorePortfolio.DAL.Context;

namespace TekKatmanliCorePortfolio.ViewComponents
{
    public class _FeauterPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
