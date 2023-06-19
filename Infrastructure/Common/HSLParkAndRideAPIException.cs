namespace Pro.APIConsume.Infrastructure.Common
{
    public class HSLParkAndRideAPIException : Exception
    {
        /// <summary>
        /// Creates new instance without message.
        /// </summary>
        public HSLParkAndRideAPIException()
        {
        }

        /// <summary>
        /// Creates new instance with message.
        /// </summary>
        /// <param name="message">The message</param>
        public HSLParkAndRideAPIException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates new instance with message and inner exception.
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="innerException">The inner exception</param>
        public HSLParkAndRideAPIException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
