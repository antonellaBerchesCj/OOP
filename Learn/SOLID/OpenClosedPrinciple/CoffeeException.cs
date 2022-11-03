using System.Runtime.Serialization;

namespace Learn.SOLID.OpenClosedPrinciple
{
    [Serializable]
    internal class CoffeeException : Exception
    {
        public CoffeeException()
        {
        }

        public CoffeeException(string? message) : base(message)
        {
        }

        public CoffeeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CoffeeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}