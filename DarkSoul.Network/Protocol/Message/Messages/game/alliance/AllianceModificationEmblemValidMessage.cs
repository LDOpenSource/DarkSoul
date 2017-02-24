

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceModificationEmblemValidMessage : NetworkMessage
    {
        public override ushort Id => 6447;
        
        
        public Types.GuildEmblem Alliancemblem;
        
        public AllianceModificationEmblemValidMessage()
        {
        }
        
        public AllianceModificationEmblemValidMessage(Types.GuildEmblem Alliancemblem)
        {
            this.Alliancemblem = Alliancemblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            Alliancemblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
        }
        
    }
    
}