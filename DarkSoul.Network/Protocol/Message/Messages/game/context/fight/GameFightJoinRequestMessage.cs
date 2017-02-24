

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
    public class GameFightJoinRequestMessage : NetworkMessage
    {
        public override ushort Id => 701;
        
        
        public double fighterId;
        public int fightId;
        
        public GameFightJoinRequestMessage()
        {
        }
        
        public GameFightJoinRequestMessage(double fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(fighterId);
            writer.WriteInt(fightId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fighterId = reader.ReadDouble();
            fightId = reader.ReadInt();
        }
        
    }
    
}