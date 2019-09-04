using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.Dtos
{
    public class PlanetsTypeDto
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}