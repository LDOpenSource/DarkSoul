

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
    public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
    {
        public override ushort Id => 5979;
        
        
        public IEnumerable<Types.MountClientData> paddockedMountsDescription;
        
        public ExchangeStartOkMountMessage()
        {
        }
        
        public ExchangeStartOkMountMessage(IEnumerable<Types.MountClientData> stabledMountsDescription, IEnumerable<Types.MountClientData> paddockedMountsDescription)
         : base(stabledMountsDescription)
        {
            this.paddockedMountsDescription = paddockedMountsDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)paddockedMountsDescription.Count());
            foreach (var entry in paddockedMountsDescription)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            paddockedMountsDescription = new Types.MountClientData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddockedMountsDescription as Types.MountClientData[])[i] = new Types.MountClientData();
                 (paddockedMountsDescription as Types.MountClientData[])[i].Deserialize(reader);
            }
        }
        
    }
    
}