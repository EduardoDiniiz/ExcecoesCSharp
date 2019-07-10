using System;


namespace ExcecoesCSharp.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base (message)
        {

        }
    }
}
