using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Trulioo.Client.V3.Models
{
    public class TokenResult
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
