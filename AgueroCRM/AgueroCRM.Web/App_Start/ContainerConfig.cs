using AgueroCRM.Data.Service;
using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace AgueroCRM.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlPotentialCustomerData>()
                   .As<IPotentialCustomerData>()
                   .InstancePerRequest();
            builder.RegisterType<SqlCustomerData>()
                   .As<ICustomerData>()
                   .InstancePerRequest();
            builder.RegisterType<SqlCustomerContractData>()
                   .As<ICustomerContractData>()
                   .InstancePerRequest();
            builder.RegisterType<SqlApplicationData>()
                   .As<IApplicationData>()
                   .InstancePerRequest();
            builder.RegisterType<AgueroCRMDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}