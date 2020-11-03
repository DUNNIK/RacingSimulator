using System;

namespace RacingSimulator.Exceptions
{
    public class DistanceException : Exception
    {
        public DistanceException() : base("A wrong value of the distance!")
        {
        }
    }
}