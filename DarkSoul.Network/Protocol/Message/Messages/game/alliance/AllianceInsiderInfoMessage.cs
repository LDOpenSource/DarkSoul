

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
    public class AllianceInsiderInfoMessage : NetworkMessage
    {
        public override ushort Id => 6403;
        
        
        public Types.AllianceFactSheetInformations allianceInfos;
        public IEnumerable<Types.GuildInsiderFactSheetInformations> guilds;
        public IEnumerable<Types.PrismSubareaEmptyInfo> prisms;
        
        public AllianceInsiderInfoMessage()
        {
        }
        
        public AllianceInsiderInfoMessage(Types.AllianceFactSheetInformations allianceInfos, IEnumerable<Types.GuildInsiderFactSheetInformations> guilds, IEnumerable<Types.PrismSubareaEmptyInfo> prisms)
        {
            this.allianceInfos = allianceInfos;
            this.guilds = guilds;
            this.prisms = prisms;
        }
        
        public override void Serialize(IWriter writer)
        {
            allianceInfos.Serialize(writer);
            writer.WriteShort((short)guilds.Count());
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)prisms.Count());
            foreach (var entry in prisms)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            allianceInfos = new Types.AllianceFactSheetInformations();
            allianceInfos.Deserialize(reader);
            var limit = reader.ReadUShort();
            guilds = new Types.GuildInsiderFactSheetInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guilds as Types.GuildInsiderFactSheetInformations[])[i] = new Types.GuildInsiderFactSheetInformations();
                 (guilds as Types.GuildInsiderFactSheetInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prisms = new Types.PrismSubareaEmptyInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (prisms as Types.PrismSubareaEmptyInfo[])[i] = ProtocolTypeManager.GetInstance<Types.PrismSubareaEmptyInfo>(reader.ReadUShort());
                 (prisms as Types.PrismSubareaEmptyInfo[])[i].Deserialize(reader);
            }
        }
        
    }
    
}