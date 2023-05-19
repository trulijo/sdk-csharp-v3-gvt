namespace Trulioo.Client.V3.Models.Errors
{
    /// <summary>
    /// Provides a class that represents a Trulioo service response error message.
    /// </summary>
    public class Error : AbstractError
    {
        #region Properties

        /// <summary>
        /// Gets the reason of the current <see cref="Error"/>.
        /// </summary>
        /// <value>
        /// Reason of the current <see cref="Error"/>.
        /// </value>
        public string Reason { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a string representation for the current <see cref="Error"/>.
        /// </summary>
        /// <returns>
        /// A string representation of the current <see cref="Error"/>.
        /// </returns>
        /// <seealso cref="M:System.Object.ToString()"/>
        public override string ToString()
        {
            return $"{Code}:{Reason}:{Message}";
        }

        #endregion
    }
}
