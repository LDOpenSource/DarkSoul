using Newtonsoft.Json;

namespace DarkSoul.Network.IPC.Server.Json
{
    public class JsonUtility
    {
        private const int DefaultMaxDepth = 20;

        /// <summary>
        /// Creates a default <see cref="T:Newtonsoft.Json.JsonSerializerSettings"/> instance.
        /// </summary>
        /// <returns>The newly created <see cref="T:Newtonsoft.Json.JsonSerializerSettings"/>.</returns>
        public static JsonSerializerSettings CreateDefaultSerializerSettings()
        {
            return new JsonSerializerSettings() { MaxDepth = DefaultMaxDepth };
        }

        /// <summary>
        /// Creates a <see cref="T:Newtonsoft.Json.JsonSerializer"/> instance with the default setting. 
        /// </summary>
        /// <returns>The newly created <see cref="T:Newtonsoft.Json.JsonSerializerSettings"/>.</returns>
        public static JsonSerializer CreateDefaultSerializer()
        {
            return JsonSerializer.Create(CreateDefaultSerializerSettings());
        }
    }
}
