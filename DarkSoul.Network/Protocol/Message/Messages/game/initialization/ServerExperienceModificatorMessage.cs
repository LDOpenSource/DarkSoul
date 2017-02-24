

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ServerExperienceModificatorMessage : NetworkMessage
    {
        public override ushort Id => 6237;
        
        
        public ushort experiencePercent;
        
        public ServerExperienceModificatorMessage()
        {
        }
        
        public ServerExperienceModificatorMessage(ushort experiencePercent)
        {
            this.experiencePercent = experiencePercent;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)experiencePercent);
        }
        
        public override void Deserialize(IReader reader)
        {
            experiencePercent = reader.ReadVarUhShort();
        }
        
    }
    
}