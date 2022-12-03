using Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Steam.Helpers;
using Steam.Models;
using Steam.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Controllers
{
    public class HomeController : Controller
    {
        private readonly SteamDbContext context;

        public HomeController(SteamDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(string searchStr)
        {

            ViewData["CurrentFilter"] = searchStr;
            var games = from g in context.Games select g;

            if (!String.IsNullOrEmpty(searchStr))
            {
                games = games.Where(g => g.Name.Contains(searchStr));

            }
            var game = context.Games./*Where(g => g.Name.Contains(searchStr)).*/Select(g => new GameCardViewModel()
            {
                Game = g,
            }).ToList();

            foreach (var item in game)
                {
                    item.IsInCard = IsProductInCart(item.Game.Id);
                }
            //ViewBag.ReturnUrl = Request.Headers["Referer"].ToString();

            return View(game);
        }

        private bool IsProductInCart(int id)
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            if (ids == null) return false;

            return ids.Contains(id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
