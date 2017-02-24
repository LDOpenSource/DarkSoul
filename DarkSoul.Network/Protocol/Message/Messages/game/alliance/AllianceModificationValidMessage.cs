

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
    public class AllianceModificationValidMessage : NetworkMessage
    {
        public override ushort Id => 6450;
        
        
        public string allianceName;
        public string allianceTag;
        public Types.GuildEmblem Alliancemblem;
        
        public AllianceModificationValidMessage()
        {
        }
        
        public AllianceModificationValidMessage(string allianceName, string allianceTag, Types.GuildEmblem Alliancemblem)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
            this.Alliancemblem = Alliancemblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            Alliancemblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            Alliancemblem = new Types.GuildEmblem();
            Alliancemblem.Deserialize(reader);
        }
        
    }
    
}