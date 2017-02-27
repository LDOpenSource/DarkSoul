using Newtonsoft.Json;

namespace DarkSoul.Network.Interface
{
    public interface IConnection
    {
        JsonSerializer JsonSerializer { get; }
    }
}
