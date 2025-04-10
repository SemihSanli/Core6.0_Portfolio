﻿using Microsoft.AspNetCore.Mvc;
using TekKatmanliCorePortfolio.DAL.Context;
using TekKatmanliCorePortfolio.DAL.Entities;

namespace TekKatmanliCorePortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
