using System;

namespace JogoDaVelha
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
