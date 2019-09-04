using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIVERSE.Dtos
{
    public class NewVisitDto
    {
        public int CreatureId { get; set; }
        public List<int> PlanetIds { get; set; }
    }
}