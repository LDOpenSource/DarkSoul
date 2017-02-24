

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportToBuddyAnswerMessage : NetworkMessage
    {
        public override ushort Id => 6293;
        
        
        public ushort dungeonId;
        public double buddyId;
        public bool accept;
        
        public TeleportToBuddyAnswerMessage()
        {
        }
        
        public TeleportToBuddyAnswerMessage(ushort dungeonId, double buddyId, bool accept)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.accept = accept;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
            accept = reader.ReadBoolean();
        }
        
    }
    
}