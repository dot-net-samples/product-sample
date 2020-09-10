using Product.Business;
using Product.Data;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ProductManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductDataRepository, ProductDataRepository>();
            container.RegisterType<IProductBusiness, ProductBusiness>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}