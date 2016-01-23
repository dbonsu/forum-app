using AutoMapper;
using ForumApp.DataModel;

namespace ForumApp.BusinessEntities.BusinessAutoMapping
{
    public static class BusinessMapperConfig
    {
        public static void Configure()
        {
            //Mappings
            Mapper.CreateMap<Forum, ForumEntity>()
                .ForMember(dec => dec.User, opt => opt.MapFrom(src => src.User));
            Mapper.CreateMap<User, SimpleUserDTO>()
                .ForMember(d => d.UserID, opt => opt.MapFrom(src => src.ID))
                .ForMember(d => d.RoleName, opt => opt.MapFrom(src => src.Role.RoleName));
        }
    }
}