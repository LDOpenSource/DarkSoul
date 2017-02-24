

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
    {
        public override ushort Id => 6469;
        
        
        public IEnumerable<ushort> serverIds;
        
        public SelectedServerDataExtendedMessage()
        {
        }
        
        public SelectedServerDataExtendedMessage(ushort serverId, string address, ushort port, bool canCreateNewCharacter, IEnumerable<sbyte> ticket, IEnumerable<ushort> serverIds)
         : base(serverId, address, port, canCreateNewCharacter, ticket)
        {
            this.serverIds = serverIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)serverIds.Count());
            foreach (var entry in serverIds)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            serverIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (serverIds as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}