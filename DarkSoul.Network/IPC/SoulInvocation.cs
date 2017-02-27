using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics.CodeAnalysis;

namespace DarkSoul.Network.IPC
{
    internal class SoulInvocation
    {
        [JsonProperty("H")]
        public string Soul { get; set; }
        [JsonProperty("M")]
        public string Method { get; set; }
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Justification = "This type is used for serialization")]
        [JsonProperty("A")]
        public JToken[] Args { get; set; }
        [JsonProperty("I")]
        public string CallbackId { get; set; }
    }
}