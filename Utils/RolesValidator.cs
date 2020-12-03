using System;
using System.Collections.Generic;

namespace HotelTDD.Utils
{
    public class RolesValidator
    {
        private string _errorMessages;

        public static RolesValidator New()
        {
            return new RolesValidator();
        }

        public RolesValidator When(bool hasError, string errorMessage)
        {
            if (hasError)
                _errorMessages += errorMessage + "; ";

            return this;
        }


        public void ThrowExceptionIfExists()
        {
            if (_errorMessages != null)
                throw new DomainException(_errorMessages);
        }
    }

    public class DomainException : ArgumentException
    {
        public List<string> ErrorMessages { get; set; }

        public DomainException(string message) : base(message)
        {
        }
    }
}
