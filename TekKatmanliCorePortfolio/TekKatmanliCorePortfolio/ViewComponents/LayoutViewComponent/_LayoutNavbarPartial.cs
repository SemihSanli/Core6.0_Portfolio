using Microsoft.AspNetCore.Mvc;
using TekKatmanliCorePortfolio.DAL.Context;

namespace TekKatmanliCorePortfolio.ViewComponents.LayoutViewComponent
{
    public class _LayoutNavbarPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount=context.ToDoLists.Where(x=>x.Status==false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
