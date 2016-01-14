using AutoMapper;
using ForumApp.DataModel;

namespace ForumApp.BusinessEntities.BusinessAutoMapping
{
    public static class BusinessMapperConfig
    {
        public static void Configure()
        {
            //Mappings
            Mapper.CreateMap<Forum, ForumEntity>();
            Mapper.CreateMap<User, UserEntity>();
            Mapper.CreateMap<Password, PasswordEntity>();
        }
    }
}