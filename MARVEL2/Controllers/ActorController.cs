using MARVEL2.Models;
using MARVEL2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MARVEL2.Controllers
{
    public class ActorController : Controller
    {
        
        private readonly MARVEL2DbContext _context;

        private readonly ILogger<ActorController> _logger;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ActorController(ILogger<ActorController> logger) => _logger = logger;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        // GET: ActorController
        public IActionResult Index()
        {
            var heroesData = Models.Helper.Heroes.GetAll();

            var model = new ActorViewModel
            {
                HeroesSelectList = new List<SelectListItem>()
            };

            foreach (var hero in heroesData)
            {
                model.HeroesSelectList.Add(new SelectListItem { Text = hero.HeroName });
            }


            var moviesData = Models.Helper.Movies.GetAll();

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            var models = new ActorViewModel
            {
                MoviesSelectList = new List<SelectListItem>()
            };
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            foreach (Movie movie in moviesData)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                model.MoviesSelectList.Add(new SelectListItem { Text = movie.Name });
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }

            return View(model);
        }

        // GET: ActorController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: ActorController1/Create
        public IActionResult Create()
        {           
            return View();
        }

        // POST: ActorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birthdate")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                actor.Id = Guid.NewGuid();
                object value = _context.Add(actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // GET: ActorController1/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: ActorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ActorController1/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: ActorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
