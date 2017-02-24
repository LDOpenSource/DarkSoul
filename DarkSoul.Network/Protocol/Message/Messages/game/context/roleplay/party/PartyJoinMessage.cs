

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
    public class PartyJoinMessage : AbstractPartyMessage
    {
        public override ushort Id => 5576;
        
        
        public sbyte partyType;
        public double partyLeaderId;
        public sbyte maxParticipants;
        public IEnumerable<Types.PartyMemberInformations> members;
        public IEnumerable<Types.PartyGuestInformations> guests;
        public bool restricted;
        public string partyName;
        
        public PartyJoinMessage()
        {
        }
        
        public PartyJoinMessage(uint partyId, sbyte partyType, double partyLeaderId, sbyte maxParticipants, IEnumerable<Types.PartyMemberInformations> members, IEnumerable<Types.PartyGuestInformations> guests, bool restricted, string partyName)
         : base(partyId)
        {
            this.partyType = partyType;
            this.partyLeaderId = partyLeaderId;
            this.maxParticipants = maxParticipants;
            this.members = members;
            this.guests = guests;
            this.restricted = restricted;
            this.partyName = partyName;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(partyType);
            writer.WriteVarLong(partyLeaderId);
            writer.WriteSByte(maxParticipants);
            writer.WriteShort((short)members.Count());
            foreach (var entry in members)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)guests.Count());
            foreach (var entry in guests)
            {
                 entry.Serialize(writer);
            }
            writer.WriteBoolean(restricted);
            writer.WriteUTF(partyName);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            partyType = reader.ReadSByte();
            partyLeaderId = reader.ReadVarUhLong();
            maxParticipants = reader.ReadSByte();
            var limit = reader.ReadUShort();
            members = new Types.PartyMemberInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as Types.PartyMemberInformations[])[i] = ProtocolTypeManager.GetInstance<Types.PartyMemberInformations>(reader.ReadUShort());
                 (members as Types.PartyMemberInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            guests = new Types.PartyGuestInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guests as Types.PartyGuestInformations[])[i] = new Types.PartyGuestInformations();
                 (guests as Types.PartyGuestInformations[])[i].Deserialize(reader);
            }
            restricted = reader.ReadBoolean();
            partyName = reader.ReadUTF();
        }
        
    }
    
}