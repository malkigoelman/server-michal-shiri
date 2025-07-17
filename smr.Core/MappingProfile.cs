using AutoMapper;
using smr.Core.DTOs;
using smr.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smr.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Renter, renterDTO>().ReverseMap();
            CreateMap<Tourist, touirstDTO>().ReverseMap();
            CreateMap<Turn,TurnDTO>().ReverseMap();
        }
    }
}
