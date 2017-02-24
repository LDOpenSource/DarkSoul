

// Generated on 02/23/2017 16:53:56
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeStartOkMountWithOutPaddockMessage : NetworkMessage
    {
        public override ushort Id => 5991;
        
        
        public IEnumerable<Types.MountClientData> stabledMountsDescription;
        
        public ExchangeStartOkMountWithOutPaddockMessage()
        {
        }
        
        public ExchangeStartOkMountWithOutPaddockMessage(IEnumerable<Types.MountClientData> stabledMountsDescription)
        {
            this.stabledMountsDescription = stabledMountsDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)stabledMountsDescription.Count());
            foreach (var entry in stabledMountsDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            stabledMountsDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (stabledMountsDescription as Types.MountClientData[])[i] = new Types.MountClientData();
                 (stabledMountsDescription as Types.MountClientData[])[i].Deserialize(reader);
            }
        }
        
    }
    
}