using DarkSoul.Core.Interfaces;

namespace DarkSoul.Network.Protocol.Message
{
    public class BasicPongMessage : NetworkMessage
    {
        public override ushort Id => 183;

        public bool quiet;

        public BasicPongMessage()
        {
        }

        public BasicPongMessage(bool quiet)
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
