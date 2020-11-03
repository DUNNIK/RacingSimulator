using System;
using System.Runtime.Serialization;

namespace RacingSimulator.Exceptions
{
    public class AddTransportException : Exception
    {
        public AddTransportException() : base("You can't add this type of transport")
        {
        }
    }
}