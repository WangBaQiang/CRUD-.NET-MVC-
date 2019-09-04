using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIVERSE.Models
{
    public class Privilege
    {
        public byte Id { get; set; }
        public short stonesNeeded { get; set; }
        public byte DurationOfPrivilege { get; set; }
        public byte PrivilegeRate { get; set; }
        public string privilegeName { get; set; }
        public static readonly byte Unkown = 0;
        public static readonly byte RateOne = 1;
    }
}