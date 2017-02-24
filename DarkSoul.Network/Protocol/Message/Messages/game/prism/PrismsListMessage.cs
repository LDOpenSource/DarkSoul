

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismsListMessage : NetworkMessage
    {
        public override ushort Id => 6440;
        
        
        public IEnumerable<Types.PrismSubareaEmptyInfo> prisms;
        
        public PrismsListMessage()
        {
        }
        
        public PrismsListMessage(IEnumerable<Types.PrismSubareaEmptyInfo> prisms)
        {
            this.prisms = prisms;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)prisms.Count());
            foreach (var entry in prisms)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            prisms = new Types.PrismSubareaEmptyInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (prisms as Types.PrismSubareaEmptyInfo[])[i] = ProtocolTypeManager.GetInstance<Types.PrismSubareaEmptyInfo>(reader.ReadUShort());
                 (prisms as Types.PrismSubareaEmptyInfo[])[i].Deserialize(reader);
            }
        }
        
    }
    
}