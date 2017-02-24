

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DungeonKeyRingUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6296;
        
        
        public ushort dungeonId;
        public bool available;
        
        public DungeonKeyRingUpdateMessage()
        {
        }
        
        public DungeonKeyRingUpdateMessage(ushort dungeonId, bool available)
        {
            this.dungeonId = dungeonId;
            this.available = available;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteBoolean(available);
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            available = reader.ReadBoolean();
        }
        
    }
    
}