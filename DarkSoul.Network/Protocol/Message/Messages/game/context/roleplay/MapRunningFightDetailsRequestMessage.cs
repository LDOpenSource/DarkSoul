

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapRunningFightDetailsRequestMessage : NetworkMessage
    {
        public override ushort Id => 5750;
        
        
        public int fightId;
        
        public MapRunningFightDetailsRequestMessage()
        {
        }
        
        public MapRunningFightDetailsRequestMessage(int fightId)
        {
            this.fightId = fightId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
        }
        
    }
    
}