using DarkSoul.Core.Interfaces;

namespace DarkSoul.Network.Protocol.Message
{
    public class BasicPingMessage : NetworkMessage
    {
        public override ushort Id => 182;

        public bool quiet;

        public BasicPingMessage()
        {
        }

        public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }

        public override void Deserialize(IReader reader)
        {
            quiet = reader.ReadBoolean();
        }

        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(quiet);
        }
    }
}
