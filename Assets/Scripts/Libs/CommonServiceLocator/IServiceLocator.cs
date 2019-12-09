
using System;
using System.Collections;
using System.Collections.Generic;

namespace CommonServiceLocator
{
    public interface IServiceLocator : IServiceProvider
    {
        
        object GetInstance(Type serviceType);

        object GetInstance(Type serviecType , string key);

        IEnumerable<object> GetAllInstances(Type serviceType);

        TService GetInstance<TService>();

        TService GetInstance<TService>(string key);

        IEnumerable<TService> GetInstances<TService>();
        
    }
}