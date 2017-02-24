

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
    {
        public override ushort Id => 5589;
        
        
        public double memberId;
        public bool active;
        
        public CompassUpdatePartyMemberMessage()
        {
        }
        
        public CompassUpdatePartyMemberMessage(sbyte type, Types.MapCoordinates coords, double memberId, bool active)
         : base(type, coords)
        {
            this.memberId = memberId;
            this.active = active;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(memberId);
            writer.WriteBoolean(active);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            memberId = reader.ReadVarUhLong();
            active = reader.ReadBoolean();
        }
        
    }
    
}