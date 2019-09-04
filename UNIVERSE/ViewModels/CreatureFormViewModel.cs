using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNIVERSE.Models;

namespace UNIVERSE.ViewModels
{
    public class CreatureFormViewModel
    {
        public IEnumerable<Privilege> privileges { get; set; }
        public Creature creature { get; set; }
    }
}