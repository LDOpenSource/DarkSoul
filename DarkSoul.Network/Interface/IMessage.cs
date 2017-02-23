using DarkSoul.Core.Interfaces;

namespace DarkSoul.Network.Interface
{
    public interface IMessage
    {
        /// <summary>
        /// Network Message Identifier
        /// </summary>
        ushort Id { get; }
        /// <summary>
        /// Write Message
        /// </summary>
        /// <param name="writer"></param>
        void Pack(IWriter writer);
        /// <summary>
        /// Read Message
        /// </summary>
        /// <param name="reader"></param>
        void Unpack(IReader reader);
    }
}
