using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Trulioo.Client.V3.Models.Errors;

namespace Trulioo.Client.V3.Models.Business
{
    /// <summary>
    /// The request to be passed to Client for a business search
    /// </summary>
    public class BusinessSearchRequest
    {
        /// <summary>
        ///  The Package ID to run the transaction under
        /// </summary>
        public string PackageId { get; set; }

        /// <summary>
        /// If set, the transaction will run asyncronously and Trulioo will try to update the client with transaction state updates until completed.
        /// </summary>
        public string CallBackUrl { get; set; }

        /// <summary>
        /// If set, Trulioo will try to update the client syncronously within the timeout in seconds. If failed to accomplish, the transaction will be canceled.
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Some datasources require your customer provide consent to access them.  Set that the customer has provided consent for each
        /// datasource that requires one.  If consent is not provided the datasource will not be queried.
        /// Included only for the data sources which explicitly require consent
        /// </summary>
        public string[] ConsentForDataSources { get; set; }

        /// <summary>
        /// Contains the data that will be used for the business search
        /// </summary>
        public BusinessSearchModel Business { get; set; }

        /// <summary>
        /// The country code for which the search needs to be performed
        /// Two-letter alpha code for the country for which the search needs to be performed. 
        /// </summary>
        public string CountryCode { get; set; }
    }
}
