

// Generated on 02/23/2017 16:53:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DungeonPartyFinderListenRequestMessage : NetworkMessage
    {
        public override ushort Id => 6246;
        
        
        public ushort dungeonId;
        
        public DungeonPartyFinderListenRequestMessage()
        {
        }
        
        public DungeonPartyFinderListenRequestMessage(ushort dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
        }
        
    }
    
}