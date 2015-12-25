using Autofac;
using ForumApp.Common;
using ForumApp.Services.Interfaces;
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
            builder.RegisterType<ForumService>().As<IForumService>();
            builder.RegisterType<ForumThreadService>().As<IForumThreadService>();
            builder.RegisterType<IMService>().As<IIMService>();
            builder.RegisterType<LoginAttemptService>().As<ILoginAttemptService>();
            builder.RegisterType<PasswordService>().As<IPasswordService>();
            builder.RegisterType<ThreadReplyService>().As<IThreadReplyService>();
            builder.RegisterType<TopicService>().As<ITopicService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserSubscription>().As<IUserSubscriptionService>();
        }
    }
}