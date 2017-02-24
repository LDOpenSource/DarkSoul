

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
    public class PartyInvitationDungeonMessage : PartyInvitationMessage
    {
        public override ushort Id => 6244;
        
        
        public ushort dungeonId;
        
        public PartyInvitationDungeonMessage()
        {
        }
        
        public PartyInvitationDungeonMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId, ushort dungeonId)
         : base(partyId, partyType, partyName, maxParticipants, fromId, fromName, toId)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)dungeonId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
        }
        
    }
    
}