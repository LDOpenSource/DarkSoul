

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
    public class PartyInvitationDetailsMessage : AbstractPartyMessage
    {
        public override ushort Id => 6263;
        
        
        public sbyte partyType;
        public string partyName;
        public double fromId;
        public string fromName;
        public double leaderId;
        public IEnumerable<Types.PartyInvitationMemberInformations> members;
        public IEnumerable<Types.PartyGuestInformations> guests;
        
        public PartyInvitationDetailsMessage()
        {
        }
        
        public PartyInvitationDetailsMessage(uint partyId, sbyte partyType, string partyName, double fromId, string fromName, double leaderId, IEnumerable<Types.PartyInvitationMemberInformations> members, IEnumerable<Types.PartyGuestInformations> guests)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyName = partyName;
            this.fromId = fromId;
            this.fromName = fromName;
            this.leaderId = leaderId;
            this.members = members;
            this.guests = guests;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteUTF(partyName);
            writer.WriteVarLong(fromId);
            writer.WriteUTF(fromName);
            writer.WriteVarLong(leaderId);
            writer.WriteShort((short)members.Count());
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)guests.Count());
            foreach (var entry in guests)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            partyType = reader.ReadSByte();
            partyName = reader.ReadUTF();
            fromId = reader.ReadVarUhLong();
            fromName = reader.ReadUTF();
            leaderId = reader.ReadVarUhLong();
            var limit = reader.ReadUShort();
            members = new Types.PartyInvitationMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as Types.PartyInvitationMemberInformations[])[i] = new Types.PartyInvitationMemberInformations();
                 (members as Types.PartyInvitationMemberInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            guests = new Types.PartyGuestInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guests as Types.PartyGuestInformations[])[i] = new Types.PartyGuestInformations();
                 (guests as Types.PartyGuestInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}