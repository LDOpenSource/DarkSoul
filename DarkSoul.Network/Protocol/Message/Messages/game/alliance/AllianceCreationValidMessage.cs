

// Generated on 02/23/2017 16:53:21
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceCreationValidMessage : NetworkMessage
    {
        public override ushort Id => 6393;
        
        
        public string allianceName;
        public string allianceTag;
        public Types.GuildEmblem allianceEmblem;
        
        public AllianceCreationValidMessage()
        {
        }
        
        public AllianceCreationValidMessage(string allianceName, string allianceTag, Types.GuildEmblem allianceEmblem)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
            this.allianceEmblem = allianceEmblem;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
            allianceEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
            allianceEmblem = new Types.GuildEmblem();
            allianceEmblem.Deserialize(reader);
        }
        
    }
    
}