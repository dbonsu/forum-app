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
            builder.Register<IForumService>(f => new ForumService(new ForumAppEntities()));
            builder.RegisterType<ForumThreadService>().As<IForumThreadService>();
            builder.RegisterType<IMService>().As<IIMService>();
            builder.RegisterType<LoginAttemptService>().As<ILoginAttemptService>();
            builder.Register<IPasswordService>(p => new PasswordService(new ForumAppEntities()));
            builder.RegisterType<ThreadReplyService>().As<IThreadReplyService>();
            builder.RegisterType<TopicService>().As<ITopicService>();
            builder.Register<IUserService>(u => new UserService(new ForumAppEntities()));
            builder.RegisterType<UserSubscription>().As<IUserSubscriptionService>();
            builder.RegisterType<LoginService>().As<ILoginService>();
            builder.Register<IFakeService>(f => new FakeService(new System.Net.Http.HttpClient()));
        }
    }
}