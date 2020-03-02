using System;
using System.Runtime.Serialization;

namespace AgroAnaliseApp.Services
{
    [Serializable]
    internal class DbConcurrencyException : Exception
    {
        public DbConcurrencyException()
        {
        }

        public DbConcurrencyException(string message) : base(message)
        {
        }

        public DbConcurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}