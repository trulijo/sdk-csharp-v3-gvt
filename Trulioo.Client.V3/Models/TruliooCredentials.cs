using System;
using System.Collections.Generic;
using System.Text;

namespace Trulioo.Client.V3.Models
{
    public class TruliooCredentials
    {
        public string BearerToken { get; set; }
        public DateTime BearerTokenExpiresAt { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
