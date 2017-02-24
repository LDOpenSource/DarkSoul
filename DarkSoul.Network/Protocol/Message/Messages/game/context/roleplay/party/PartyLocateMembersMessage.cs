

// Generated on 02/23/2017 16:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyLocateMembersMessage : AbstractPartyMessage
    {
        public override ushort Id => 5595;
        
        
        public IEnumerable<Types.PartyMemberGeoPosition> geopositions;
        
        public PartyLocateMembersMessage()
        {
        }
        
        public PartyLocateMembersMessage(uint partyId, IEnumerable<Types.PartyMemberGeoPosition> geopositions)
         : base(partyId)
        {
            this.geopositions = geopositions;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)geopositions.Count());
            foreach (var entry in geopositions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            geopositions = new Types.PartyMemberGeoPosition[limit];
            for (int i = 0; i < limit; i++)
            {
                 (geopositions as Types.PartyMemberGeoPosition[])[i] = new Types.PartyMemberGeoPosition();
                 (geopositions as Types.PartyMemberGeoPosition[])[i].Deserialize(reader);
            }
        }
        
    }
    
}