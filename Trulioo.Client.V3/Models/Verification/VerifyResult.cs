using System;
using System.Collections.Generic;
using Trulioo.Client.V3.Models.Errors;
using Trulioo.Client.V3.Models.Response;

namespace Trulioo.Client.V3.Models.Verification
{
    public class VerifyResult
    {
        /// <summary>
        /// The id for the transaction it will be a GUID
        /// </summary>
        public string TransactionID { get; set; }

        /// <summary>
        /// Uploaded date and time in UTC
        /// </summary>
        public DateTime UploadedDt { get; set; }

        /// <summary>
        /// Completed date and time in UTC
        /// </summary>
        public DateTime CompletedDt { get; set; }

        /// <summary>
        /// Country Code 
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The record of the results
        /// </summary>
        public Record Record { get; set; }

        /// <summary>
        /// Customer Reference Id
        /// </summary>
        public string CustomerReferenceID { get; set; }

        /// <summary>
        /// <list type="bullet">
        ///     <item>
        ///         <term>1000 : Provider Error</term>
        ///         <description>There was an error connecting to the source</description>
        ///     </item>
        ///     <item>
        ///         <term>1001 : Missing Required Field</term>
        ///     </item>
        ///     <item>
        ///         <term>1002 : Datasource Unavailable</term>
        ///         <description>The source did not respond</description>
        ///     </item>
        ///     <item>
        ///         <term>1003 : Datasource Error</term>
        ///         <description>The source returned an error</description>
        ///     </item>
        ///     <item>
        ///         <term>1004 : State Not Supported</term>
        ///         <description>AU driver license</description>
        ///     </item>
        ///     <item>
        ///         <term>1005 : Missing Consent</term>
        ///         <description>consent not sent for the source</description>
        ///     </item>
        ///     <item>
        ///         <term>1008 : Invalid Field Format</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term>2000 : Unrecognized Error</term>
        ///         <description></description>
        ///     </item>
        ///     <item>
        ///         <term>Address Messages</term>
        ///         <description>These let you know the address was corrected in some way</description>
        ///     </item>
        ///     <item>
        ///         <term>3000</term>
        ///         <description>Address Corrected</description>
        ///     </item>
        ///     <item>
        ///         <term>3001</term>
        ///         <description>State Province Changed</description>
        ///     </item>
        ///     <item>
        ///         <term>3002</term>
        ///         <description>City Changed</description>
        ///     </item>
        ///     <item>
        ///         <term>3003</term>
        ///         <description>Street Info Changed</description>
        ///     </item>
        ///     <item>
        ///         <term>3004</term>
        ///         <description>Postal Code Changed</description>
        ///     </item>
        ///     <item>
        ///         <term>3005</term>
        ///         <description>Missing Address Info</description>
        ///     </item>
        ///     <item>
        ///         <term>3008</term>
        ///         <description>Can not validate Address</description>
        ///     </item>
        /// </list>
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }
    }
}
