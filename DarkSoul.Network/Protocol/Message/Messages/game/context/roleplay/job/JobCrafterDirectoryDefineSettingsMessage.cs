

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
    {
        public override ushort Id => 5649;
        
        
        public Types.JobCrafterDirectorySettings settings;
        
        public JobCrafterDirectoryDefineSettingsMessage()
        {
        }
        
        public JobCrafterDirectoryDefineSettingsMessage(Types.JobCrafterDirectorySettings settings)
        {
            this.settings = settings;
        }
        
        public override void Serialize(IWriter writer)
        {
            settings.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            settings = new Types.JobCrafterDirectorySettings();
            settings.Deserialize(reader);
        }
        
    }
    
}