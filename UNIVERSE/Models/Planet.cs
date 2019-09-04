using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.Models
{
    public class Planet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name filed is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Galaxy field is required")]
        public string Galaxy { get; set; }
        [Required(ErrorMessage = "Features field is required")]
        public string Features { get; set; }
        [Display(Name = "Total Load")]
        public byte TotalLoad { get; set; }
        public byte VisitersAvailable { get; set; }
        [Required(ErrorMessage = "Tpye field is required")]
        public byte PlanetsTypeId { get; set; }
        
        public PlanetsType PlanetsType { get; set; }
     
    }
}