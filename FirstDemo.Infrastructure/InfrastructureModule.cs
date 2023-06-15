using Autofac;
using FirstDemo.Application;
using FirstDemo.Application.Features.Training.Repositories;
using FirstDemo.Application.Features.Training.Services;
using FirstDemo.Infrastructure.Features.Services;

namespace FirstDemo.Infrastructure
{
    public class InfrastructureModule : Module
    {
		public InfrastructureModule()
        { 
		}

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseService>().As<ICourseService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
