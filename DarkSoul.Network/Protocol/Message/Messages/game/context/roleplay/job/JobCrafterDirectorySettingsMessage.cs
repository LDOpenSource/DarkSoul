

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
    public class JobCrafterDirectorySettingsMessage : NetworkMessage
    {
        public override ushort Id => 5652;
        
        
        public IEnumerable<Types.JobCrafterDirectorySettings> craftersSettings;
        
        public JobCrafterDirectorySettingsMessage()
        {
        }
        
        public JobCrafterDirectorySettingsMessage(IEnumerable<Types.JobCrafterDirectorySettings> craftersSettings)
        {
            this.craftersSettings = craftersSettings;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)craftersSettings.Count());
            foreach (var entry in craftersSettings)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            craftersSettings = new Types.JobCrafterDirectorySettings[limit];
            for (int i = 0; i < limit; i++)
            {
                 (craftersSettings as Types.JobCrafterDirectorySettings[])[i] = new Types.JobCrafterDirectorySettings();
                 (craftersSettings as Types.JobCrafterDirectorySettings[])[i].Deserialize(reader);
            }
        }
        
    }
    
}