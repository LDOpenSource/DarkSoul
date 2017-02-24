

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MoodSmileyUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6388;
        
        
        public int accountId;
        public double playerId;
        public ushort smileyId;
        
        public MoodSmileyUpdateMessage()
        {
        }
        
        public MoodSmileyUpdateMessage(int accountId, double playerId, ushort smileyId)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(accountId);
            writer.WriteVarLong(playerId);
            writer.WriteVarShort((int)smileyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            accountId = reader.ReadInt();
            playerId = reader.ReadVarUhLong();
            smileyId = reader.ReadVarUhShort();
        }
        
    }
    
}