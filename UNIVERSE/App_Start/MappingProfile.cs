using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using UNIVERSE.Models;
using UNIVERSE.Dtos;


namespace UNIVERSE.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Creature, CreatureDto>();
            Mapper.CreateMap<Privilege, PrivilegeDto>();
            Mapper.CreateMap<PlanetsType, PlanetsTypeDto>();
            Mapper.CreateMap<CreatureDto, Creature>()  .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Planet, PlanetDto>();
            Mapper.CreateMap<PlanetDto, Planet>().ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}