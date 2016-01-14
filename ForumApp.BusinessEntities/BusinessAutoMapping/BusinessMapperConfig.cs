using AutoMapper;
using ForumApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.BusinessEntities.BusinessAutoMapping
{
    public static class BusinessMapperConfig
    {
        public static void Configure()
        {
            //Mappings
            Mapper.CreateMap<Forum, ForumEntity>()
                .ForMember(dec => dec.User, opt => opt.MapFrom(src => src.User));
        }
    }
}