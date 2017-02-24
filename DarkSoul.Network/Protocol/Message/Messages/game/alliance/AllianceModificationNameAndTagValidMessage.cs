

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
    public class AllianceModificationNameAndTagValidMessage : NetworkMessage
    {
        public override ushort Id => 6449;
        
        
        public string allianceName;
        public string allianceTag;
        
        public AllianceModificationNameAndTagValidMessage()
        {
        }
        
        public AllianceModificationNameAndTagValidMessage(string allianceName, string allianceTag)
        {
            this.allianceName = allianceName;
            this.allianceTag = allianceTag;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(allianceName);
            writer.WriteUTF(allianceTag);
        }
        
        public override void Deserialize(IReader reader)
        {
            allianceName = reader.ReadUTF();
            allianceTag = reader.ReadUTF();
        }
        
    }
    
}