

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
    public class PartyInvitationMessage : AbstractPartyMessage
    {
        public override ushort Id => 5586;
        
        
        public sbyte partyType;
        public string partyName;
        public sbyte maxParticipants;
        public double fromId;
        public string fromName;
        public double toId;
        
        public PartyInvitationMessage()
        {
        }
        
        public PartyInvitationMessage(uint partyId, sbyte partyType, string partyName, sbyte maxParticipants, double fromId, string fromName, double toId)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.maxParticipants = maxParticipants;
            this.fromId = fromId;
            this.fromName = fromName;
            this.toId = toId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteSByte(maxParticipants);
            writer.WriteVarLong(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVarLong(toId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            partyType = reader.ReadSByte();
            partyName = reader.ReadUTF();
            maxParticipants = reader.ReadSByte();
            fromId = reader.ReadVarUhLong();
            fromName = reader.ReadUTF();
            toId = reader.ReadVarUhLong();
        }
        
    }
    
}