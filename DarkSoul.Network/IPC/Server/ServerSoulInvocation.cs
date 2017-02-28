using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DarkSoul.Network.IPC.Server
{
    public class ServerSoulInvocation
    {
        [JsonProperty("S")]
        public string Soul { get; set; }
        [JsonProperty("M")]
        public string Method { get; set; }
        [JsonProperty("A")]
        public JRaw[] Args { get; set; }
        [JsonProperty("C")]
        public string CallbackId { get; set; }
    }
}
