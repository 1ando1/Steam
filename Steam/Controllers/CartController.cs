using Data.Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Steam.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Controllers
{
    public class CartController : Controller
    {
        private readonly SteamDbContext context;

        public CartController(SteamDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");
            if (ids == null) ids = new List<int>();

            List<Game?> games = ids.Select(id => context.Games.Find(id)).ToList();

            return View(games);
        }

        public IActionResult Add(int id)
        {
            if (context.Games.Find(id) == null) return NotFound();

            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");

            if (ids == null) ids = new List<int>();

            ids.Add(id);

            HttpContext.Session.SetObject("cartKey", ids);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int id)
        {
            List<int>? ids = HttpContext.Session.GetObject<List<int>>("cartKey");

            if (ids == null) return NotFound();

            ids.Remove(id);

            HttpContext.Session.SetObject("cartKey", ids);

            return RedirectToAction("Index", "Home");
        }
    }
}
