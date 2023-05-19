using System.Collections.Generic;
using Trulioo.Client.V3.Models.Errors;

namespace Trulioo.Client.V3.Models.Response
{
    /// <summary>
    /// Record of the response
    /// </summary>
    public class Record
    {
        /// <summary>
        /// The TransactionRecordID, this is the ID you will use to fetch the transaction again.
        /// </summary>
        public string TransactionRecordID { get; set; }

        /// <summary>
        /// 'match' or 'nomatch' if the verification passed the rules configured on your account this will be 'match'.
        /// </summary>
        public string RecordStatus { get; set; }

        /// <summary>
        /// 'match' or 'nomatch' if the secondary verification was run and passed the rules configured on your account this will be 'match'.
        /// </summary>
        public string SecondaryRecordStatus { get; set; }

        /// <summary>
        /// Results for each datasource that was queried
        /// </summary>
        public IEnumerable<DatasourceResult> DatasourceResults { get; set; }

        /// <summary>
        /// Errors returned from the service
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        /// Rule used for record
        /// </summary>
        public RecordRule Rule { get; set; }
    }
}
