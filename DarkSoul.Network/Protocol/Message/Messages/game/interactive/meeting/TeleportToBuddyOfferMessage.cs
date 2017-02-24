

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
    public class TeleportToBuddyOfferMessage : NetworkMessage
    {
        public override ushort Id => 6287;
        
        
        public ushort dungeonId;
        public double buddyId;
        public uint timeLeft;
        
        public TeleportToBuddyOfferMessage()
        {
        }
        
        public TeleportToBuddyOfferMessage(ushort dungeonId, double buddyId, uint timeLeft)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.timeLeft = timeLeft;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            writer.WriteVarInt((int)timeLeft);
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
            timeLeft = reader.ReadVarUhInt();
        }
        
    }
    
}