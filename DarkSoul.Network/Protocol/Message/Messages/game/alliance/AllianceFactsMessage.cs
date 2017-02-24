

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
    public class AllianceFactsMessage : NetworkMessage
    {
        public override ushort Id => 6414;
        
        
        public Types.AllianceFactSheetInformations infos;
        public IEnumerable<Types.GuildInAllianceInformations> guilds;
        public IEnumerable<ushort> controlledSubareaIds;
        public double leaderCharacterId;
        public string leaderCharacterName;
        
        public AllianceFactsMessage()
        {
        }
        
        public AllianceFactsMessage(Types.AllianceFactSheetInformations infos, IEnumerable<Types.GuildInAllianceInformations> guilds, IEnumerable<ushort> controlledSubareaIds, double leaderCharacterId, string leaderCharacterName)
        {
            this.infos = infos;
            this.guilds = guilds;
            this.controlledSubareaIds = controlledSubareaIds;
            this.leaderCharacterId = leaderCharacterId;
            this.leaderCharacterName = leaderCharacterName;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteShort((short)guilds.Count());
            foreach (var entry in guilds)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)controlledSubareaIds.Count());
            foreach (var entry in controlledSubareaIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteVarLong(leaderCharacterId);
            writer.WriteUTF(leaderCharacterName);
        }
        
        public override void Deserialize(IReader reader)
        {
            infos = ProtocolTypeManager.GetInstance<Types.AllianceFactSheetInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
            var limit = reader.ReadUShort();
            guilds = new Types.GuildInAllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (guilds as Types.GuildInAllianceInformations[])[i] = new Types.GuildInAllianceInformations();
                 (guilds as Types.GuildInAllianceInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            controlledSubareaIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (controlledSubareaIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            leaderCharacterId = reader.ReadVarUhLong();
            leaderCharacterName = reader.ReadUTF();
        }
        
    }
    
}