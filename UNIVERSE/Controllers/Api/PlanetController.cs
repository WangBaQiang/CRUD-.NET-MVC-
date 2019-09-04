using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNIVERSE.Models;
using AutoMapper;
using UNIVERSE.Dtos;
using System.Data.Entity;

namespace UNIVERSE.Controllers.Api
{
    public class PlanetController : ApiController
    {
        private ApplicationDbContext _context;
        public PlanetController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetPlanet()
        {
            var planetDtos = _context.Planets.Include(c=>c.PlanetsType).ToList().Select(Mapper.Map<Planet, PlanetDto>);
            return Ok(planetDtos);
        }
        public IHttpActionResult GetPlanetById(int id)
        {
            var planet = _context.Planets.SingleOrDefault(c => c.Id == id);
            if (planet == null)
                return BadRequest();
            return Ok(Mapper.Map<Planet, PlanetDto>(planet));
        }
        [HttpPost]
        public IHttpActionResult CreatePlanet(PlanetDto planetDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var planet= Mapper.Map<PlanetDto, Planet>(planetDto);
            _context.Planets.Add(planet);
            _context.SaveChanges();
            planetDto.Id = planet.Id;
            return Created(new Uri(Request.RequestUri + "/" + planet.Id), planetDto);
        }
        [HttpPut]
        public IHttpActionResult UpdatePlanet(int id, PlanetDto planetDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var planetInDb = _context.Planets.SingleOrDefault(c => c.Id == id);
            if (planetInDb == null)
                return NotFound();
            Mapper.Map(planetDto, planetInDb);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeletePlanet(int id)
        {
            var planet = _context.Planets.SingleOrDefault(c => c.Id == id);
            if (planet == null)
                return NotFound();
            _context.Planets.Remove(planet);
            _context.SaveChanges();
            return Ok();

        }

    }
}
