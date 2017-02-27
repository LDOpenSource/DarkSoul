using Newtonsoft.Json;

namespace DarkSoul.Network.IPC.Server
{
    public class ServerMsgResult
    {
        /// <summary>
        /// The callback identifier
        /// </summary>
        [JsonProperty("I")]
        public string Id { get; set; }

        /// <summary>
        /// The return value of the hub
        /// </summary>
        [JsonProperty("R")]
        public object Result { get; set; }

        /// <summary>
        /// The error message returned from the hub invocation.
        /// </summary>
        [JsonProperty("E")]
        public string Error { get; set; }
    }
}
