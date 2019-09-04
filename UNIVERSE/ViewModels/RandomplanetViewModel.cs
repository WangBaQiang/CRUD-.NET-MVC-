using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNIVERSE.Models;

namespace UNIVERSE.ViewModels
{
    public class RandomplanetViewModel
    {
        public Planet Planet { get; set; }
        public List<Creature> Creatures { get; set; }
    }
}