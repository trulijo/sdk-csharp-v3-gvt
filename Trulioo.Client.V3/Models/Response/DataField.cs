namespace Trulioo.Client.V3.Models.Response
{
    /// <summary>
    /// A data field from the results
    /// </summary>
    public class DataField
    {
        /// <summary>
        /// Name of the field
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Value of the field
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Field grouping
        /// </summary>
        public string FieldGroup { get; set; }
    }
}
