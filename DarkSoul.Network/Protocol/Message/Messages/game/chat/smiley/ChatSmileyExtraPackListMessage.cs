

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChatSmileyExtraPackListMessage : NetworkMessage
    {
        public override ushort Id => 6596;
        
        
        public IEnumerable<sbyte> packIds;
        
        public ChatSmileyExtraPackListMessage()
        {
        }
        
        public ChatSmileyExtraPackListMessage(IEnumerable<sbyte> packIds)
        {
            this.packIds = packIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)packIds.Count());
            foreach (var entry in packIds)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            packIds = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (packIds as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}