using Autofac;
using ForumApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.IocConfig
{
    public class ServiceIOC : CustomModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}