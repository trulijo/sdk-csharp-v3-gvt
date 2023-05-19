using System;
using System.Collections.Generic;
using Trulioo.Client.V3.Models.Errors;

namespace Trulioo.Client.V3.Models.Business
{
    /// <summary>
    /// Response object returned from Business Search containing metadata and results from search
    /// </summary>
    public class BusinessSearchResponse
    {
        /// <summary>
        /// The id for the transaction. It will be a GUID
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Upload date and time in UTC
        /// </summary>
        public DateTime UploadedDt { get; set; }

        /// <summary>
        /// The country code for which the search was performed.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// RecordResult for the Business Search
        /// </summary>
        public BusinessRecord Record { get; set; }

        /// <summary>
        /// Collection of record errors
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }
    }
}
