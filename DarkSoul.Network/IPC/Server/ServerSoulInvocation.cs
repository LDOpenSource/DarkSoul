using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DarkSoul.Network.IPC.Server
{
    public class ServerSoulInvocation
    {
        [JsonProperty("H")]
        public string Soul { get; set; }
        [JsonProperty("M")]
        public string Method { get; set; }
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "This type is used for serialization")]
        [JsonProperty("A")]
        public JRaw[] Args { get; set; }
        [JsonProperty("I")]
        public string CallbackId { get; set; }
    }
}
