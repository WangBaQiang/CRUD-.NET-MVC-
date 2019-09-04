using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNIVERSE.Models;
using UNIVERSE.ViewModels;

namespace UNIVERSE.Controllers
{   
    public class CreatureController : Controller
    {
        // GET: Creature
        private ApplicationDbContext _context;
        public CreatureController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult CreatureForm()
        {
            var privilege = _context.Privileges.ToList();
            var ViewModel = new CreatureFormViewModel
            {
                creature = new Creature(),
                privileges = privilege
            };
            return View(ViewModel);
        }

        
        //public ActionResult Details(int id)
        //{
        //    var creature = _context.Creatures.Include(c => c.Privilege).SingleOrDefault(c => c.Id == id);
        //    if (creature == null)
        //        return HttpNotFound();
        //    return View(creature);
        //}
        public ActionResult Edit (int id )
        {
            var Creature = _context.Creatures.SingleOrDefault(c => c.Id == id);
            if (Creature == null)
                return HttpNotFound();

            else
            {
                var ViewModel = new CreatureFormViewModel
                {
                    creature = Creature,
                    privileges = _context.Privileges.ToList()

                };

                return View("CreatureForm",  ViewModel);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Creature creature)
        {
            if (!ModelState.IsValid)
            {
                var ViewModel = new CreatureFormViewModel
                {
                    creature = creature,
                    privileges = _context.Privileges.ToList()
                };
                return View("CreatureForm", ViewModel);
            }

           if (creature.Id ==0)
            {
                _context.Creatures.Add(creature);
            }
            else
            {
                var creatureInDb = _context.Creatures.Single(c => c.Id == creature.Id);
                creatureInDb.Name = creature.Name;
                creatureInDb.PrivilegeId = creature.PrivilegeId;
                creatureInDb.Birthdate = creature.Birthdate;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Creature");
        }
        private IEnumerable<Creature> GetCreatures()
        {
            return new List<Creature>
            {
                new Creature{Id = 1, Name="Dog"},
                 new Creature{Id = 2, Name="Cat"},
                 new Creature{Id = 3, Name="Fish"},
            };
        }
    }
}