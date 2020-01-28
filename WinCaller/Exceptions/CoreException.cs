using System;
using System.Collections.Generic;
using System.Text;

namespace WinCaller.Exceptions
{
    class CoreException : Exception
    {
        public CoreException()
            :base()
        {

        }

        public CoreException(string message)
            :base(message)
        {
            
        }

        public CoreException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}
