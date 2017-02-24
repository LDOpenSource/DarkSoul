

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChallengeInfoMessage : NetworkMessage
    {
        public override ushort Id => 6022;
        
        
        public ushort challengeId;
        public double targetId;
        public uint xpBonus;
        public uint dropBonus;
        
        public ChallengeInfoMessage()
        {
        }
        
        public ChallengeInfoMessage(ushort challengeId, double targetId, uint xpBonus, uint dropBonus)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
            this.xpBonus = xpBonus;
            this.dropBonus = dropBonus;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
            writer.WriteVarInt((int)xpBonus);
            writer.WriteVarInt((int)dropBonus);
        }
        
        public override void Deserialize(IReader reader)
        {
            challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
            xpBonus = reader.ReadVarUhInt();
            dropBonus = reader.ReadVarUhInt();
        }
        
    }
    
}