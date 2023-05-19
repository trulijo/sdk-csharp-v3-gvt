namespace Trulioo.Client.V3.Models.Errors
{
    /// <summary>
    /// Errors returned from the service
    /// </summary>
    public class ServiceError : AbstractError
    {
        /// <summary>
        /// Gets a string representation for the current <see cref="ServiceError"/>.
        /// </summary>
        /// <returns>
        /// A string representation of the current <see cref="ServiceError"/>.
        /// </returns>
        /// <seealso cref="M:System.Object.ToString()"/>
        public override string ToString()
        {
            return $"{Code}:{Message}";
        }
    }
}
