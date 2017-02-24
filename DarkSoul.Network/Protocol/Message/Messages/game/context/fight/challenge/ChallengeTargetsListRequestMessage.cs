

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
    public class ChallengeTargetsListRequestMessage : NetworkMessage
    {
        public override ushort Id => 5614;
        
        
        public ushort challengeId;
        
        public ChallengeTargetsListRequestMessage()
        {
        }
        
        public ChallengeTargetsListRequestMessage(ushort challengeId)
        {
            this.challengeId = challengeId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)challengeId);
        }
        
        public override void Deserialize(IReader reader)
        {
            challengeId = reader.ReadVarUhShort();
        }
        
    }
    
}