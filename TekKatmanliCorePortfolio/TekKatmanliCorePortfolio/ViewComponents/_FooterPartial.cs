using Microsoft.AspNetCore.Mvc;
using TekKatmanliCorePortfolio.DAL.Context;

namespace TekKatmanliCorePortfolio.ViewComponents
{
    public class _FooterPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
         var values=context.SocialMedias.ToList();
            return View(values);
        }
    }
}
