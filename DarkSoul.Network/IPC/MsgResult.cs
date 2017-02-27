using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DarkSoul.Network.IPC
{
    /// <summary>
    /// A implementation based on signalr from Microsoft
    /// </summary>
    public class MsgResult
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
        public JToken Result { get; set; }

        /// <summary>
        /// The error message returned from the hub invocation.
        /// </summary>
        [JsonProperty("E")]
        public string Error { get; set; }
    }
}
