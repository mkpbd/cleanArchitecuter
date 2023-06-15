using Autofac;
using FirstDemo.Application;
using FirstDemo.Application.Features.Training.Repositories;
using FirstDemo.Web.Areas.Admin.Models;

namespace FirstDemo.Web
{
    public class WebModule : Module
    {
		public WebModule()
        { }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseListModel>().AsSelf()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseCreateModel>().AsSelf()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseUpdateModel>().AsSelf()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
