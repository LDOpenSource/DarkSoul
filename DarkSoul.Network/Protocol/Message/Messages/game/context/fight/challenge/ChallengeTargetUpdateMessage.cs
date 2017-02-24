

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
    public class ChallengeTargetUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6123;
        
        
        public ushort challengeId;
        public double targetId;
        
        public ChallengeTargetUpdateMessage()
        {
        }
        
        public ChallengeTargetUpdateMessage(ushort challengeId, double targetId)
        {
            this.challengeId = challengeId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)challengeId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            challengeId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
        }
        
    }
    
}