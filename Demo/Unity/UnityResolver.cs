using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;

namespace Demo.Unity
{
    public class UnityResolver : IDependencyResolver
    {
        protected IUnityContainer Container;

        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            Container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                Debug.WriteLine("GetService: {0}", serviceType);
                return Container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                Debug.WriteLine("GetServices: {0}", serviceType);
                return Container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            Debug.WriteLine("BeginScope");
            var child = Container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}