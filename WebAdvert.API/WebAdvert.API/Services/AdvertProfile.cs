using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace WebAdvert.API.Services
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile(string profileName)
        {
            CreateMap<AdvertDBModel, AdvertDBModel>();
        }
    }
}
