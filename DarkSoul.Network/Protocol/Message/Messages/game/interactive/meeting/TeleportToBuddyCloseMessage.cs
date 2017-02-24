

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
    public class TeleportToBuddyCloseMessage : NetworkMessage
    {
        public override ushort Id => 6303;
        
        
        public ushort dungeonId;
        public double buddyId;
        
        public TeleportToBuddyCloseMessage()
        {
        }
        
        public TeleportToBuddyCloseMessage(ushort dungeonId, double buddyId)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
        }
        
    }
    
}