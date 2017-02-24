

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class NumericWhoIsMessage : NetworkMessage
    {
        public override ushort Id => 6297;
        
        
        public double playerId;
        public int accountId;
        
        public NumericWhoIsMessage()
        {
        }
        
        public NumericWhoIsMessage(double playerId, int accountId)
        {
            this.playerId = playerId;
            this.accountId = accountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(playerId);
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            playerId = reader.ReadVarUhLong();
            accountId = reader.ReadInt();
        }
        
    }
    
}