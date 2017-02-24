

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AccessoryPreviewRequestMessage : NetworkMessage
    {
        public override ushort Id => 6518;
        
        
        public IEnumerable<ushort> genericId;
        
        public AccessoryPreviewRequestMessage()
        {
        }
        
        public AccessoryPreviewRequestMessage(IEnumerable<ushort> genericId)
        {
            this.genericId = genericId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)genericId.Count());
            foreach (var entry in genericId)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            genericId = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (genericId as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}