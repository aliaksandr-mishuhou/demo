using System;
using System.Diagnostics;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Demo.BusinessServices;
using Demo.BusinessServices.Impl;
using Microsoft.Practices.Unity;

namespace Demo.Unity
{
    public class UnityServiceActivator : IHttpControllerActivator
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public UnityServiceActivator(HttpConfiguration configuration)
        {
            Init();
        }

        private void Init()
        {
            _container.RegisterType<IShop, Shop>();
        }


        public IHttpController Create(HttpRequestMessage request
            , HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            Debug.WriteLine("Create: {0}", controllerType);
            var controller = _container.RegisterType(controllerType).Resolve(controllerType) as IHttpController;
            return controller;
        }
    }
}