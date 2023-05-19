using Trulioo.Client.V3.Models.Fields;

namespace Trulioo.Client.V3.Models.Business
{
    /// <summary>
    /// Search model containing name-value pairs to be used for Business Search
    /// </summary>
    public class BusinessSearchModel
    {
        /// <summary>
        /// Name of the business to be verified
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// Website of the business
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Jurisdiction Of Incorporation of the business to be verified
        /// </summary>
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        /// DUNS number of the business to be verified
        /// </summary>
        public string DUNSNumber { get; set; }

        /// <summary>
        /// Location of business to be verified
        /// </summary>
        public Location Location { get; set; }
    }
}
