using Autofac;
using ForumApp.Common.Utility;

namespace ForumApp.Common.CommonIocConfig
{
    public class CommonIOC : CustomModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PasswordHash>().As<IPasswordHash>();
            builder.RegisterType<TokenUtility>().As<ITokenUtility>();
        }
    }
}