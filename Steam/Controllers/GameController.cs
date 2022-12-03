using Data.Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace Steam.Controllers
{
    public class GameController : Controller
    {

        private readonly SteamDbContext context;

        public GameController(SteamDbContext context)
        {
            this.context = context;
        }

        [Authorize(Roles = "Administrators")]
        public IActionResult Index(string searchStr)
        {

            ViewData["CurrentFilter"] = searchStr;
            var games = from g in context.Games select g;

            if (!String.IsNullOrEmpty(searchStr))
                games = games.Where(g => g.Name.Contains(searchStr));
            return View(games);
        }

        public IActionResult Details(int id)
        {
            Game? game = context.Games.Find(id);

            if (game == null) return NotFound();

            return View(game);
        }

        //[Authorize(Roles = "Administrators")]
        public IActionResult Edit(int id)
        {
            Game game = context.Games.Find(id);

            if (game == null) return NotFound();

            return View(game);
        }

        [HttpPost]
        //[Authorize(Roles = "Administrators")]
        public IActionResult Edit(Game game)
        {
            context.Entry(game).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction(nameof(HomeController.Index));
        }

        //[Authorize(Roles = "Administrators")]
        public IActionResult Delete(int id)
        {
            Game game = context.Games.Find(id);
            if (game != null)
            {
                context.Games.Remove(game);
                context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        //[Authorize(Roles = "Administrators")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Roles = "Administrators")]
        public IActionResult Add(Game game)
        {
            context.Games.Add(game);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
