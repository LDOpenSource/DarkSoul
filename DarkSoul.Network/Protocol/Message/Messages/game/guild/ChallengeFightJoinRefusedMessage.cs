

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChallengeFightJoinRefusedMessage : NetworkMessage
    {
        public override ushort Id => 5908;
        
        
        public double playerId;
        public sbyte reason;
        
        public ChallengeFightJoinRefusedMessage()
        {
        }
        
        public ChallengeFightJoinRefusedMessage(double playerId, sbyte reason)
        {
            this.playerId = playerId;
            this.reason = reason;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(playerId);
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(IReader reader)
        {
            playerId = reader.ReadVarUhLong();
            reason = reader.ReadSByte();
        }
        
    }
    
}