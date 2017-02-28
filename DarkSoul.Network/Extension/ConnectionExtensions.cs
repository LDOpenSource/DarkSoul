using DarkSoul.Network.Interface;
using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Text;

namespace DarkSoul.Network.Extension
{
    public static class ConnectionExtensions
    {
        public static T Parse<T>(this JsonSerializer serializer, string json)
        {
            if (serializer == null)
            {
                throw new ArgumentNullException("serializer");
            }

            using (var reader = new StringReader(json))
            {
                return (T)serializer.Deserialize(reader, typeof(T));
            }
        }

        public static T JsonDeserializeObject<T>(this IConnection connection, string jsonValue)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            using (var stringReader = new StringReader(jsonValue))
            {
                using (var jsonTextReader = new JsonTextReader(stringReader) { CloseInput = false })
                {
                    return (T)connection.JsonSerializer.Deserialize(jsonTextReader, typeof(T));
                }
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "jsonWriter will not dispose the stringWriter")]
        public static string JsonSerializeObject(this IConnection connection, object value)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            var sb = new StringBuilder(0x100);
            using (var stringWriter = new StringWriter(sb, CultureInfo.InvariantCulture))
            {
                using (var jsonWriter = new JsonTextWriter(stringWriter) { CloseOutput = false })
                {
                    jsonWriter.Formatting = connection.JsonSerializer.Formatting;
                    connection.JsonSerializer.Serialize(jsonWriter, value);
                }

                return stringWriter.ToString();
            }
        }
    }
}
