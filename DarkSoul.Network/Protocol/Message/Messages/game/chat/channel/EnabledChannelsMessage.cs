

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
    public class EnabledChannelsMessage : NetworkMessage
    {
        public override ushort Id => 892;
        
        
        public IEnumerable<sbyte> channels;
        public IEnumerable<sbyte> disallowed;
        
        public EnabledChannelsMessage()
        {
        }
        
        public EnabledChannelsMessage(IEnumerable<sbyte> channels, IEnumerable<sbyte> disallowed)
        {
            this.channels = channels;
            this.disallowed = disallowed;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)channels.Count());
            foreach (var entry in channels)
            {
                 writer.WriteSByte(entry);
            }
            writer.WriteShort((short)disallowed.Count());
            foreach (var entry in disallowed)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            channels = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (channels as sbyte[])[i] = reader.ReadSByte();
            }
            limit = reader.ReadUShort();
            disallowed = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (disallowed as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}