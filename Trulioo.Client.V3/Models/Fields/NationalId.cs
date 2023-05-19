namespace Trulioo.Client.V3.Models.Fields
{
    /// <summary>
    /// 
    /// </summary>
    public class NationalId
    {
        /// <summary>
        /// 
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Supported Types: NationalID, Health, SocialService, TaxIDNumber
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>NationalID</term>
        ///         <description></description>
        ///     </listheader>
        ///     <item>
        ///         <term>China</term>
        ///         <description>National ID Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Finland</term>
        ///         <description>PIC</description>
        ///     </item>
        ///     <item>
        ///         <term>France</term>
        ///         <description>INSEE Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Hong Kong</term>
        ///         <description>Identity Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Malaysia</term>
        ///         <description>National Registration ID Card (NRIC) Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Mexico</term>
        ///         <description>CURP</description>
        ///     </item>
        ///     <item>
        ///         <term>Singapore</term>
        ///         <description>National Registration ID Card (NRIC) Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Sweden</term>
        ///         <description>Personal Identification Number (PIN)</description>
        ///     </item>
        ///     <item>
        ///         <term>Spain</term>
        ///         <description>Documento Nacional de Identidad (DNI)</description>
        ///     </item>
        ///     <item>
        ///         <term>Turkey</term>
        ///         <description>Türkiye Cumhuriyeti Kimlik Numarası (T.C. Kimlik No.)</description>
        ///     </item>
        ///     <item>
        ///         <term>India</term>
        ///         <description>Aadhaar Card Number</description>
        ///     </item>
        /// </list>
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>Health</term>
        ///         <description></description>
        ///     </listheader>
        ///     <item>
        ///         <term>Australia</term>
        ///         <description>Medicare</description>
        ///     </item>
        ///     <item>
        ///         <term>UK</term>
        ///         <description>NHS Number</description>
        ///     </item>
        /// </list>
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>SocialService</term>
        ///         <description></description>
        ///     </listheader>
        ///     <item>
        ///         <term>Australia</term>
        ///         <description>Tax File Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Canada</term>
        ///         <description>Social Insurance Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Ireland</term>
        ///         <description>Personal Public Service Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Italy</term>
        ///         <description>Codice Fiscale</description>
        ///     </item>
        ///     <item>
        ///         <term>Mexico</term>
        ///         <description>Registro Federal de Contribuyentes (Tax Number)</description>
        ///     </item>
        ///     <item>
        ///         <term>UK</term>
        ///         <description>National Insurance Number (NI)</description>
        ///     </item>
        ///     <item>
        ///         <term>US</term>
        ///         <description>Social Security Number</description>
        ///     </item>
        ///     <item>
        ///         <term>Russia</term>
        ///         <description>Individual Insurance Account Number, SNILS (11 digits)</description>
        ///     </item>
        ///     <item>
        ///         <term>India</term>
        ///         <description>Permanent Account Number (PAN)</description>
        ///     </item>
        /// </list>
        /// <list type="bullet">
        ///     <listheader>
        ///         <term>TaxIDNumber</term>
        ///     </listheader>
        ///     <item>
        ///         <term>Russia</term>
        ///         <description>Taxpayer Personal Identification Number, INN (12 digits)</description>
        ///     </item>
        /// </list>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// District that issued the ID
        /// </summary>
        public string DistrictOfIssue { get; set; }

        /// <summary>
        /// City that issued the ID
        /// </summary>
        public string CityOfIssue { get; set; }

        /// <summary>
        /// Province that issued the ID
        /// </summary>
        public string ProvinceOfIssue { get; set; }

        /// <summary>
        /// County that issued the ID
        /// </summary>
        public string CountyOfIssue { get; set; }
    }
}
