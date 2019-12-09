using System;

namespace CommonServiceLocator
{
    public static class ServiceLocator
    {
        private static ServiceLocatorProvider _currentProvider;
        public static bool IsLocationProviderSet => _currentProvider != null;
            
        public static IServiceLocator Current
        {
            get
            {
                if(!IsLocationProviderSet){throw new InvalidCastException(" ServiceLocationProvider must be set!");}

                return _currentProvider();
            }
        }

        public static void SetLocatorProvider(ServiceLocatorProvider newProvider)
        {
            _currentProvider = newProvider;
        }
        
        
    }
}