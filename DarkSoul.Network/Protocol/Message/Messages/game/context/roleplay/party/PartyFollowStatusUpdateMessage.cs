

// Generated on 02/23/2017 16:53:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
    {
        public override ushort Id => 5581;
        
        
        public bool success;
        public bool isFollowed;
        public double followedId;
        
        public PartyFollowStatusUpdateMessage()
        {
        }
        
        public PartyFollowStatusUpdateMessage(uint partyId, bool success, bool isFollowed, double followedId)
         : base(partyId)
        {
            this.success = success;
            this.isFollowed = isFollowed;
            this.followedId = followedId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isFollowed);
            writer.WriteByte(flag1);
            writer.WriteVarLong(followedId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            isFollowed = BooleanByteWrapper.GetFlag(flag1, 1);
            followedId = reader.ReadVarUhLong();
        }
        
    }
    
}