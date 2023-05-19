namespace Trulioo.Client.V3.Models.Business
{
    public class BusinessSearchResponseIndustryCode
    {
        public BusinessSearchResponseIndustryCode(string code, string description)
        {
            Code = code;
            Description = description;
        }
        public string Code { get; }
        public string Description { get; }
    }
}
