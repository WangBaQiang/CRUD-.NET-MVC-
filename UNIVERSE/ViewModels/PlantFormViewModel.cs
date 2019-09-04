using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNIVERSE.Models;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.ViewModels
{
    public class PlantFormViewModel
    {
        public IEnumerable<PlanetsType> PlanetsTypes { get; set; }
        [Required]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Galaxy { get; set; }
        [Required]
        public string Features { get; set; }
        [Required]
        public byte? PlanetsTypeId { get; set; }

        public PlantFormViewModel()
        {
            Id = 0;
        }
        public PlantFormViewModel(Planet planet)
        {
            Id = planet.Id;
            Name = planet.Name;
            Galaxy = planet.Galaxy;
            Features = planet.Features;
            PlanetsTypeId = planet.PlanetsTypeId;
        }
    }
}