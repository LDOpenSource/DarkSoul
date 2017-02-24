

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class NpcDialogCreationMessage : NetworkMessage
    {
        public override ushort Id => 5618;
        
        
        public int mapId;
        public int npcId;
        
        public NpcDialogCreationMessage()
        {
        }
        
        public NpcDialogCreationMessage(int mapId, int npcId)
        {
            this.mapId = mapId;
            this.npcId = npcId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(mapId);
            writer.WriteInt(npcId);
        }
        
        public override void Deserialize(IReader reader)
        {
            mapId = reader.ReadInt();
            npcId = reader.ReadInt();
        }
        
    }
    
}