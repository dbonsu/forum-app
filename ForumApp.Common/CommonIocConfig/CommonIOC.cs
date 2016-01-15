using Autofac;
using ForumApp.Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Common.CommonIocConfig
{
    public class CommonIOC : CustomModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PasswordHash>().As<IPasswordHash>();
        }
    }
}