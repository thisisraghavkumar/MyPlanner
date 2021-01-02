using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using MyPlanner.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPlanner.Web
{
    public class ContainerConfig
    {
        public static void RegisterContainer(System.Web.Http.HttpConfiguration configuration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryTasks>().As<IPlannerTasks>().SingleInstance();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}