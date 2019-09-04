using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace UNIVERSE.Models
{
    public class Creature
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name field is required.")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display (Name = "Privilege Level")]
        [Required(ErrorMessage ="Privilege Level is required") ]
        public byte PrivilegeId { get; set; }
        public Privilege Privilege { get; set; }
   

            [Display (Name= "Date of Birth")]
            [min18yesarsIfPrivileged]
        public DateTime? Birthdate { get; set; }
    }
}