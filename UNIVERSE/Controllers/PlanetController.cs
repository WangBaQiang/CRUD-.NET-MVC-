using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNIVERSE.Models;
using UNIVERSE.ViewModels;
using System.Data.Entity;

namespace UNIVERSE.Controllers
{
    public class PlanetController : Controller
    {
        private ApplicationDbContext _context;
        public PlanetController()
        {
            _context = new ApplicationDbContext();
        }
        // Remember to dispose the DbContext
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Planet
        public ViewResult Index()
        {
            if (User.IsInRole("CanManagePlanets"))
                return View("List");
            return View("ReadOnlyList");
        }
        [Authorize(Roles = RoleNames.CanManagePlanets)]
        public ActionResult CreatePlanet()
        {
            var planetType = _context.PlanetsTypes.ToList();
            var ViewModel = new PlantFormViewModel
            {
                PlanetsTypes = planetType,
                
            };
            return View("PlanetForm", ViewModel);
        }
        public ActionResult EditPlanet(int id)
        {
            var Planet = _context.Planets.Single(c => c.Id == id);
            if (Planet == null)
            {
                return HttpNotFound();
            }
            else {
                var ViewModel = new PlantFormViewModel(Planet)
                {
                    
                    PlanetsTypes = _context.PlanetsTypes.ToList()
                };
                return View("PlanetForm", ViewModel);
        } }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Planet planet)
        {
            if (!ModelState.IsValid)
            {
                var ViewModel = new PlantFormViewModel(planet)
                {
                    PlanetsTypes = _context.PlanetsTypes.ToList()
                };
                return View("PlanetForm", ViewModel);
            }
            if (planet.Id == 0)
            {
                _context.Planets.Add(planet);
            }

            else
            {
                var planetInDb = _context.Planets.Single(c => c.Id == planet.Id);
                planetInDb.Name = planet.Name;
                planetInDb.Galaxy = planet.Galaxy;
                planetInDb.Features = planet.Features;
                planetInDb.PlanetsTypeId = planet.PlanetsTypeId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Planet");
        }
      public ActionResult Details(int id)
        {
            var planet = _context.Planets.Include(c=>c.PlanetsType).SingleOrDefault(c => c.Id == id);
            if (planet == null)
                return HttpNotFound();
            else return View(planet);
        }
 
        public ActionResult Random()
        {
            var planet = new Planet() { Name = "Sirius" };
            var creatures = new List<Creature>
            {
                new Creature {Name = "dog"},
                new Creature {Name  ="cat" }

            };
            var viewModel = new RandomplanetViewModel()
            {
                Planet = planet,
                Creatures = creatures

            };

            return View(viewModel);
        }

    }
}