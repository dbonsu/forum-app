using Autofac;
using ForumApp.Common;
using ForumApp.DataModel.Repository;
using ForumApp.DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.DataModelIocConfig
{
    public class ForumDataIOC : CustomModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<BaseRepository>().As<IBaseRepository>();
        }
    }
}