using Microsoft.AspNetCore.Mvc;
using TekKatmanliCorePortfolio.DAL.Context;

namespace TekKatmanliCorePortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5= context.Portfolios.Count();
            ViewBag.v7 = context.Experiences.Count();
            ViewBag.v6 = context.Testimonials.Where(x => x.Title == "Yazılım Mühendisi").Count();
            ViewBag.v8=context.Testimonials.Count();
            ViewBag.v9 = context.Portfolios.Where(x => x.SubTitle == ".Net MVC5 İle Geliştirilmiştir").Count();
            ViewBag.v10 = context.Skills.Where(x => x.SkillValue == 70).Count();
            ViewBag.v11 = context.Experiences.Where(x => x.Date == "Mart 2024-Haziran 2024").Count();
            ViewBag.v12 = context.SocialMedias.Count();
            return View();
        }
    }
}
