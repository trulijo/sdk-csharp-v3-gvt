namespace Trulioo.Client.V3.Models.Errors
{
    public abstract class AbstractError
    {
        /// <summary>
        /// Gets the code of the current <see cref="AbstractError"/>.
        /// </summary>
        /// <value>
        /// Code of the current <see cref="AbstractError"/>.
        /// </value>
        public int Code { get; set; }

        /// <summary>
        /// Gets the message of the current <see cref="AbstractError"/>.
        /// </summary>
        /// <value>
        /// Message of the current <see cref="AbstractError"/>.
        /// </value>
        public string Message { get; set; }
    }
}
