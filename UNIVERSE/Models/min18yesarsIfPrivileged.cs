using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNIVERSE.Models
{
    public class min18yesarsIfPrivileged:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var creature = (Creature)validationContext.ObjectInstance;
            if (creature.PrivilegeId==Privilege.Unkown ||creature.PrivilegeId==Privilege.RateOne)
            {
                return ValidationResult.Success;
            }
            if(creature.Birthdate==null)
            {
                return new ValidationResult("Birthdate is required.");
            }
            var age = DateTime.Today.Year - creature.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success :
                new ValidationResult("Creature should be at least 18 years old to get privilege.");        }
    }
}