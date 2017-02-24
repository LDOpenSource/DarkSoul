

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
    public class AchievementFinishedInformationMessage : AchievementFinishedMessage
    {
        public override ushort Id => 6381;
        
        
        public string name;
        public double playerId;
        
        public AchievementFinishedInformationMessage()
        {
        }
        
        public AchievementFinishedInformationMessage(ushort id, byte finishedlevel, string name, double playerId)
         : base(id, finishedlevel)
        {
            this.name = name;
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}