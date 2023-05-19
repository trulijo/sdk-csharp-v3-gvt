using System.Collections.Generic;

namespace Trulioo.Client.V3.Models.Verification
{
    public class VerifyResultPartial : VerifyResult
    {
        public IEnumerable<string> DatasourcesAwaitingResult { get; set; }
        public string Status { get; set; }
    }
}
