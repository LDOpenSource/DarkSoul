

// Generated on 02/23/2017 16:53:17
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AchievementFinishedMessage : NetworkMessage
    {
        public override ushort Id => 6208;
        
        
        public ushort id;
        public byte finishedlevel;
        
        public AchievementFinishedMessage()
        {
        }
        
        public AchievementFinishedMessage(ushort id, byte finishedlevel)
        {
            this.id = id;
            this.finishedlevel = finishedlevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)id);
            writer.WriteByte(finishedlevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadVarUhShort();
            finishedlevel = reader.ReadByte();
        }
        
    }
    
}