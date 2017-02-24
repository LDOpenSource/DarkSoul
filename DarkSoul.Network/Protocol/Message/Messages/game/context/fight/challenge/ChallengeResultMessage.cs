

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
    public class ChallengeResultMessage : NetworkMessage
    {
        public override ushort Id => 6019;
        
        
        public ushort challengeId;
        public bool success;
        
        public ChallengeResultMessage()
        {
        }
        
        public ChallengeResultMessage(ushort challengeId, bool success)
        {
            this.challengeId = challengeId;
            this.success = success;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)challengeId);
            writer.WriteBoolean(success);
        }
        
        public override void Deserialize(IReader reader)
        {
            challengeId = reader.ReadVarUhShort();
            success = reader.ReadBoolean();
        }
        
    }
    
}