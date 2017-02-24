

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeMountsStableAddMessage : NetworkMessage
    {
        public override ushort Id => 6555;
        
        
        public IEnumerable<Types.MountClientData> mountDescription;
        
        public ExchangeMountsStableAddMessage()
        {
        }
        
        public ExchangeMountsStableAddMessage(IEnumerable<Types.MountClientData> mountDescription)
        {
            this.mountDescription = mountDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)mountDescription.Count());
            foreach (var entry in mountDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            mountDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (mountDescription as Types.MountClientData[])[i] = new Types.MountClientData();
                 (mountDescription as Types.MountClientData[])[i].Deserialize(reader);
            }
        }
        
    }
    
}