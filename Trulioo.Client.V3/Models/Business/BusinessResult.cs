using System.Collections.Generic;

namespace Trulioo.Client.V3.Models.Business
{
    /// <summary>
    /// Name-value pairs returned from Business Search returned from one datasource
    /// </summary>
    public class BusinessResult
    {
        /// <summary>
        /// Index in the BusinessResult
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        /// Name of the business
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// Business name matching score
        /// </summary>
        public string MatchingScore { get; set; }

        /// <summary>
        /// Registration number of the Business
        /// </summary>
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        /// DUNS number
        /// </summary>
        public string DUNSNumber { get; set; }

        /// <summary>
        /// Tax ID number of the business
        /// </summary>
        public string BusinessTaxIDNumber { get; set; }

        /// <summary>
        /// Licence number of the business
        /// </summary>
        public string BusinessLicenseNumber { get; set; }

        /// <summary>
        /// Jurisdiction of incorporation of the business
        /// </summary>
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        /// Full address
        /// </summary>
        public string FullAddress { get; set; }

        /// <summary>
        /// Business status
        /// </summary>
        public string BusinessStatus { get; set; }

        /// <summary>
        /// Original business status
        /// </summary>
        public string OriginalBusinessStatus { get; set; }

        /// <summary>
        /// Trade style name
        /// </summary>
        public string TradeStyleName { get; set; }

        /// <summary>
        /// Business type
        /// </summary>
        public string BusinessType { get; set; }

        /// <summary>
        /// Address components
        /// </summary>
        public BusinessResultAddress Address { get; set; }

        /// <summary>
        /// Alternate business names
        /// </summary>
        public IEnumerable<string> OtherBusinessNames { get; set; }

        /// <summary>
        /// Address of the company website
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Tax identification number
        /// </summary>
        public string TaxIDNumber { get; set; }

        /// <summary>
        /// Other tax identification numbers
        /// </summary>
        public IEnumerable<string> TaxIDNumbers { get; set; }

        /// <summary>
        /// Business email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Web domain of the business 
        /// </summary>
        public string WebDomain { get; set; }

        /// <summary>
        /// Other web domains of the business
        /// </summary>
        public IEnumerable<string> WebDomains { get; set; }

        /// <summary>
        /// North American Industry Classification System
        /// </summary>
        public IEnumerable<BusinessSearchResponseIndustryCode> NAICS { get; set; }

        /// <summary>
        /// Standard Industrial Classification
        /// </summary>
        public IEnumerable<BusinessSearchResponseIndustryCode> SIC { get; set; }
    }
}
