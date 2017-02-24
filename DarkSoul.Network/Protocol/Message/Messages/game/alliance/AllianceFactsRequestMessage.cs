

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceFactsRequestMessage : NetworkMessage
    {
        public override ushort Id => 6409;
        
        
        public uint allianceId;
        
        public AllianceFactsRequestMessage()
        {
        }
        
        public AllianceFactsRequestMessage(uint allianceId)
        {
            this.allianceId = allianceId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)allianceId);
        }
        
        public override void Deserialize(IReader reader)
        {
            allianceId = reader.ReadVarUhInt();
        }
        
    }
    
}