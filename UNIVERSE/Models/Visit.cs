using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.Models
{
    public class Visit
    {
        public int Id { get; set; }
        [Required]
        public Creature Creature { get; set; }
        [Required]
        public Planet Planet { get; set; }
        public DateTime DateCome { get; set; }
        public DateTime? DateBack { get; set; }
    }
}