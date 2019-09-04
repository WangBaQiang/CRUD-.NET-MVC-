using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UNIVERSE.Models;
using AutoMapper;
using System.Data.Entity;
using UNIVERSE.Dtos;

namespace UNIVERSE.Controllers.Api
{
    public class CreatureController : ApiController
    {
        private ApplicationDbContext _context;
        public CreatureController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCreatures()
        {
          var creatureDtos =    _context.Creatures.Include(c=>c.Privilege).ToList().Select(Mapper.Map<Creature,CreatureDto>);
            return Ok(creatureDtos);
        }
        public IHttpActionResult GetCreatureById(int id )
        {
            var creature = _context.Creatures.SingleOrDefault(c => c.Id == id);
            if (creature == null)
                return BadRequest();
            return Ok(Mapper.Map<Creature, CreatureDto>(creature));
        }
        [HttpPost]
        public IHttpActionResult CreateCreature(CreatureDto creatureDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var creature = Mapper.Map<CreatureDto, Creature>(creatureDto);
            _context.Creatures.Add(creature);
            _context.SaveChanges();
            creatureDto.Id = creature.Id;
            return Created(new Uri(Request.RequestUri + "/" + creature.Id), creatureDto);
        }
        [HttpPut]
        public IHttpActionResult UpdateCrature(int id, CreatureDto creatureDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var creatureInDb = _context.Creatures.SingleOrDefault(c => c.Id == id);
            if (creatureInDb == null)
                return NotFound();
            Mapper.Map(creatureDto, creatureInDb);
            _context.SaveChanges ();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteCreature(int id)
        {
            var creature = _context.Creatures.SingleOrDefault(c => c.Id == id);
            if (creature == null)
                return NotFound();
            _context.Creatures.Remove(creature);
            _context.SaveChanges();
            return Ok();

        }

        
    }
}
