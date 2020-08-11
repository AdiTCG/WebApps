using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using DataAccessor;
using DemoProj.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DemoProj
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<CollegeDbContext>().As<ICollegeDbContext>();
                // OR
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataAccessor)));
                /*.Where(t => t.Namespace.Contains("SubFolder"));*/
                /*.As(t=>t.GetInterfaces().FirstOrDefault(i=>i.Name = "I"+t.Name));*/
            builder.RegisterApiControllers(typeof(CollegeController).Assembly);
            return builder.Build();
        }
    }
}