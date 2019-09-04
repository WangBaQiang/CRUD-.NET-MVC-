using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNIVERSE.Dtos;
using UNIVERSE.Models;
using System.Web.Mvc;



namespace UNIVERSE.Controllers.Api
{
    public class NewVisitController : ApiController
    {
        private ApplicationDbContext _context;
        public NewVisitController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [HttpPost]
        public IHttpActionResult CresteNewVisit(NewVisitDto NewVisit)
        {
            var creature = _context.Creatures.Single(c => c.Id == NewVisit.CreatureId);
            var planets = _context.Planets.Where(m => NewVisit.PlanetIds.Contains(m.Id)).ToList();
            foreach (var planet in planets)
            {
                if (planet.VisitersAvailable == 0)
                    return BadRequest("This planet is not available.");
                planet.VisitersAvailable--;
                var visit = new Visit
                {
                    Creature = creature,
                    Planet = planet,
                    DateCome = DateTime.Now
                };
                _context.Visits.Add(visit);

            }
            _context.SaveChanges();
            return Ok();
        }


    }
}
