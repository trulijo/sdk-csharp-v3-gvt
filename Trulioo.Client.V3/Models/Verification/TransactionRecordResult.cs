using System.Collections.Generic;
using Trulioo.Client.V3.Models.Response;

namespace Trulioo.Client.V3.Models.Verification
{
    public class TransactionRecordResult : VerifyResult
    {
        public IEnumerable<DataField> InputFields { get; set; }
    }
}