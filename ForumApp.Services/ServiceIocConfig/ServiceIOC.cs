using Autofac;
using ForumApp.Common;
using ForumApp.DataModel;
using ForumApp.Services.Interfaces;

namespace ForumApp.Services.ServiceIocConfig
{
    public class ServiceIOC : CustomModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            //ind<ITeststepService>().To<TeststepService>().InRequestScope().WithConstructorArgument("context", c => new ITMSContext());

            builder.RegisterType<ForumService>().As<IForumService>();
            builder.RegisterType<ForumThreadService>().As<IForumThreadService>();
            builder.RegisterType<IMService>().As<IIMService>();
            builder.RegisterType<LoginAttemptService>().As<ILoginAttemptService>();
            builder.RegisterType<PasswordService>().As<IPasswordService>();
            builder.RegisterType<ThreadReplyService>().As<IThreadReplyService>();
            builder.RegisterType<TopicService>().As<ITopicService>();
            builder.Register<IUserService>(u => new UserService(new ForumAppEntities()));
            builder.RegisterType<UserSubscription>().As<IUserSubscriptionService>();
            builder.RegisterType<LoginService>().As<ILoginService>();
        }
    }
}