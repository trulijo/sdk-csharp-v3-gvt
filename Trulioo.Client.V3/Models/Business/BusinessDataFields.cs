using System.Collections.Generic;
using Trulioo.Client.V3.Models.Fields;

namespace Trulioo.Client.V3.Models.Business
{
    public class BusinessDataFields
    {
        /// <summary>
        /// Name of the business to be verified
        /// </summary>
        public string BusinessName { get; set; }
        
        /// <summary>
        /// Trade Style Name of the business to be verified
        /// </summary>
        public string TradestyleName { get; set; }
        
        /// <summary>
        /// Tax ID Number of the business to be verified
        /// </summary>
        public string TaxIDNumber { get; set; }
        
        /// <summary>
        /// Registration number of business to be verified
        /// </summary>   
        public string BusinessRegistrationNumber { get; set; }
        
        /// <summary>
        /// Day of incorporation of the business to be verified
        /// </summary>   
        public int DayOfIncorporation { get; set; }
        
        /// <summary>
        /// Month of incorporation of the business to be verified
        /// </summary>   
        public int MonthOfIncorporation { get; set; }
        
        /// <summary>
        /// Year of incorporation of the business to be verified
        /// </summary>   
        public int YearOfIncorporation { get; set; }
        
        /// <summary>
        /// Jurisdiction Of Incorporation of the business to be verified
        /// </summary>   
        public string JurisdictionOfIncorporation { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve shareholderList document
        /// </summary>   
        public bool ShareholderListDocument { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve financial information document
        /// </summary>   
        public bool FinancialInformationDocument { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve enhanced profile
        /// </summary>
        public bool EnhancedProfile { get; set; }
        
        /// <summary>
        /// Duns Number
        /// </summary>
        public string DunsNumber { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve entity detail
        /// </summary>
        public bool Entities { get; set; }
        
        /// <summary>
        /// A list of people to check for their matchstatus
        /// </summary>
        public List<PersonOfSignificantControl> PeopleOfSignificantControl { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve filing detail
        /// </summary>
        public bool Filings { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve article of association document
        /// </summary>
        public bool ArticleOfAssociation { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve registration detail document
        /// </summary>
        public bool RegistrationDetails { get; set; }
        
        /// <summary>
        /// Whether or not to retrieve annual report document
        /// </summary>
        public bool AnnualReport { get; set; }
        /// <summary>
        /// Telephone number of the business to be verified
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// CountrySpecific fields
        /// {"Country" : {"Field1" : "Value",
        /// "Field2" : "Value"
        /// }}
        /// </summary>
        public CountrySpecific CountrySpecific { get; set; }

        /// <summary>
        /// Location Information
        /// </summary>
        public List<BusinessLocation> Location { get; set; }
    }
}