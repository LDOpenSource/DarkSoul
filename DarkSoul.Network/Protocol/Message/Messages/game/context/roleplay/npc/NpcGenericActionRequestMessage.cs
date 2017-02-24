

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
    public class NpcGenericActionRequestMessage : NetworkMessage
    {
        public override ushort Id => 5898;
        
        
        public int npcId;
        public sbyte npcActionId;
        public int npcMapId;
        
        public NpcGenericActionRequestMessage()
        {
        }
        
        public NpcGenericActionRequestMessage(int npcId, sbyte npcActionId, int npcMapId)
        {
            this.npcId = npcId;
            this.npcActionId = npcActionId;
            this.npcMapId = npcMapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(npcId);
            writer.WriteSByte(npcActionId);
            writer.WriteInt(npcMapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            npcId = reader.ReadInt();
            npcActionId = reader.ReadSByte();
            npcMapId = reader.ReadInt();
        }
        
    }
    
}