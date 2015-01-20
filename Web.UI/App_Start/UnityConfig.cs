using Infrastructure.UnitOfWork;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Model.Products;
using Repository.NHibernate;
using Repository.NHibernate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Mvc4;

namespace Web.UI
{
    public class UnityConfig
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            // Unity ServiceLocator
            var serviceLocator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => serviceLocator);

            // MVC
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            //configure
            container.RegisterType<IUnitOfWork, NHUnitOfWork>();

            ////repository
            container.RegisterType<IProductRepository, ProductRepository>();

            return container;
        }
    }
}