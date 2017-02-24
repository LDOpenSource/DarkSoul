

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TreasureHuntLegendaryRequestMessage : NetworkMessage
    {
        public override ushort Id => 6499;
        
        
        public ushort legendaryId;
        
        public TreasureHuntLegendaryRequestMessage()
        {
        }
        
        public TreasureHuntLegendaryRequestMessage(ushort legendaryId)
        {
            this.legendaryId = legendaryId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)legendaryId);
        }
        
        public override void Deserialize(IReader reader)
        {
            legendaryId = reader.ReadVarUhShort();
        }
        
    }
    
}