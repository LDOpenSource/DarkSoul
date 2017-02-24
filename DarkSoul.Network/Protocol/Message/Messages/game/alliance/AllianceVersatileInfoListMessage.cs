

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
    public class AllianceVersatileInfoListMessage : NetworkMessage
    {
        public override ushort Id => 6436;
        
        
        public IEnumerable<Types.AllianceVersatileInformations> alliances;
        
        public AllianceVersatileInfoListMessage()
        {
        }
        
        public AllianceVersatileInfoListMessage(IEnumerable<Types.AllianceVersatileInformations> alliances)
        {
            this.alliances = alliances;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)alliances.Count());
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            alliances = new Types.AllianceVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alliances as Types.AllianceVersatileInformations[])[i] = new Types.AllianceVersatileInformations();
                 (alliances as Types.AllianceVersatileInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}