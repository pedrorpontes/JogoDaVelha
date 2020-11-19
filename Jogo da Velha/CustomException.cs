using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
