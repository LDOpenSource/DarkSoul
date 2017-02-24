

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
    public class AreaFightModificatorUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6493;
        
        
        public int spellPairId;
        
        public AreaFightModificatorUpdateMessage()
        {
        }
        
        public AreaFightModificatorUpdateMessage(int spellPairId)
        {
            this.spellPairId = spellPairId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(spellPairId);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellPairId = reader.ReadInt();
        }
        
    }
    
}