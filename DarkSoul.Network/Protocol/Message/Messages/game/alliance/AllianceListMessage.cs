

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
    public class AllianceListMessage : NetworkMessage
    {
        public override ushort Id => 6408;
        
        
        public IEnumerable<Types.AllianceFactSheetInformations> alliances;
        
        public AllianceListMessage()
        {
        }
        
        public AllianceListMessage(IEnumerable<Types.AllianceFactSheetInformations> alliances)
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
            alliances = new Types.AllianceFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alliances as Types.AllianceFactSheetInformations[])[i] = new Types.AllianceFactSheetInformations();
                 (alliances as Types.AllianceFactSheetInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}