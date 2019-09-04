using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.Dtos
{
    public class CreatureDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
        [Required]
        public byte PrivilegeId { get; set; }
   

        public PrivilegeDto Privilege { get; set; }
   
       // [min18yesarsIfPrivileged]
        public DateTime? Birthdate { get; set; }
    }
}