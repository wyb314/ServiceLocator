using System;

namespace CommonServiceLocator.Exceptions
{
    public class ActivationException : Exception
    {

        public ActivationException()
        {
            
        }
        
        
        public ActivationException(string msg ) : base(msg)
        {
            
        }


        public ActivationException(string msg, Exception exp) : base(msg,exp)
        {
            
        }
        
    }
}