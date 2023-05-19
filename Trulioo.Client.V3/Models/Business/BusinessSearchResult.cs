using System.Collections.Generic;
using Trulioo.Client.V3.Models.Errors;

namespace Trulioo.Client.V3.Models.Business
{
    /// <summary>
    /// Result Object for Business Search containing search results from one datasource
    /// </summary>
    public class BusinessSearchResult
    {
        /// <summary>
        /// The list of businesses returned from the search 
        /// </summary>
        public IEnumerable<BusinessResult> Results { get; set; }

        /// <summary>
        /// Name of the datasource that was called
        /// </summary>
        public string DatasourceName { get; set; }

        /// <summary>
        /// List of errors returned from datasource
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; }
    }
}
