using DarkSoul.Network.Interface;
using DarkSoul.Core.Interfaces;

namespace DarkSoul.Network.Protocol
{
    public abstract class NetworkMessage : IMessage
    {
        private const byte BIT_RIGHT_SHIFT_LEN_PACKET_ID = 2;
        private const byte BIT_MASK = 3;

        public abstract ushort Id { get; }
        public abstract void Deserialize(IReader reader);
        public abstract void Serialize(IWriter writer);

        public void Pack(IWriter writer)
        {
            Serialize(writer);
            WritePacket(writer);
        }        

        public void Unpack(IReader reader)
        {
            Deserialize(reader);
        }

        private void WritePacket(IWriter output)
        {
            byte[] data = output.Data;
            output.Clear();
            var typeLen = ComputeTypeLen((uint)data.Length);
            output.WriteShort(SubComputeStaticHeader(Id, typeLen));
            switch (typeLen)
            {
                case 0:
                    return;
                case 1:
                    output.WriteByte((byte)data.Length);
                    break;
                case 2:
                    output.WriteShort((short)data.Length);
                    break;
                case 3:
                    output.WriteByte((byte)(data.Length >> 16 & 255));
                    output.WriteShort((short)(data.Length & 65535));
                    break;
            }
            output.WriteBytes(data);
        }

        private static short SubComputeStaticHeader(ushort msgId, byte typeLen) => (short)(msgId << BIT_RIGHT_SHIFT_LEN_PACKET_ID | typeLen);

        private static byte ComputeTypeLen(uint len)
        {
            if (len > 65535)
                return 3;
            else
            {
                if (len > 255)
                    return 2;
                else
                {
                    if (len > 0)
                        return 1;
                    else
                        return 0;
                }
            }
        }
    }
}
