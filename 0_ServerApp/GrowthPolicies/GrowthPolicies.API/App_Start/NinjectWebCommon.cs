using Ninject.Web.Common.WebHost;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GrowthPolicies.API.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GrowthPolicies.API.App_Start.NinjectWebCommon), "Stop")]

namespace GrowthPolicies.API.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Web;


    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }


        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                kernel.Bind(x =>
                {
                    x.FromThisAssembly()
                        .SelectAllClasses()
                        .BindDefaultInterface();
                });

                kernel.Bind(x =>
                {
                    x.From("GrowthPolicies.Repositories, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                        .SelectAllTypes()
                        .Join.FromThisAssembly().SelectAllClasses()
                        .BindDefaultInterface();
                });
                kernel.Bind(x =>
                    {
                        x.From("GrowthPolicies.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                        .SelectAllTypes()
                        .Join.FromThisAssembly().SelectAllClasses()
                        .BindDefaultInterface();
                    });
                kernel.Bind(x =>
                        {
                            x.From("GrowthPolicies.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                        .SelectAllTypes()
                      .Join.FromThisAssembly().SelectAllClasses()
                        .BindDefaultInterface();
                        });
                kernel.Bind(x =>
                            {
                                x.From("GrowthPolicies.DataAccess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                        .SelectAllTypes()
                        .Join.FromThisAssembly().SelectAllClasses()
                        .BindDefaultInterface();
                            });
                kernel.Bind(x =>
                                {
                                    x.From("GrowthPolicies.DTO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                        .SelectAllTypes()
                        .Join.FromThisAssembly().SelectAllClasses()
                        .BindDefaultInterface();
                                });

                return kernel;
            }
            catch (Exception ex)
            {
                kernel.Dispose();
                throw ex;
            }
        }
        private static void RegisterServices(IKernel kernel)
        {
        }
    }
}
