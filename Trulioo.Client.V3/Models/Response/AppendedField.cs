namespace Trulioo.Client.V3.Models.Response
{
    /// <summary>
    /// Additional fields appended to the results
    /// </summary>
    public class AppendedField
    {
        /// <summary>
        /// Name of the appended field
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// can be string or Object(only if FieldName is WatchlistDetails)
        /// </summary>
        public dynamic Data { get; set; }
    }
}
