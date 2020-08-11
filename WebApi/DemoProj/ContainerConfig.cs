using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProj
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType< ICollegeDbContext>
            return builder.Build();
        }
    }
}