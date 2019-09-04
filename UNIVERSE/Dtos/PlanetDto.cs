using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.Dtos
{
    public class PlanetDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Galaxy { get; set; }
        [Required]
        public string Features { get; set; }
        [Required]
        public byte PlanetsTypeId { get; set; }
        [Required ]
        public PlanetsTypeDto PlanetsType { get; set; }

    }
}