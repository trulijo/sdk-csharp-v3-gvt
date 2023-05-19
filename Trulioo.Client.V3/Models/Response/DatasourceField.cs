namespace Trulioo.Client.V3.Models.Response
{
    /// <summary>
    /// A datasource field from the response
    /// </summary>
    public class DatasourceField
    {
        /// <summary>
        /// Name of the field
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Response status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The trumatch value
        /// </summary>
        public string TruMatchValue { get; set; }

        /// <summary>
        /// The threshold of the trumatch value
        /// </summary>
        public string TruMatchThreshold { get; set; }

        /// <summary>
        /// Field grouping
        /// </summary>
        public string FieldGroup { get; set; }
    }
}
