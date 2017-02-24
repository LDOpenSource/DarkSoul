

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildFactsMessage : NetworkMessage
    {
        public override ushort Id => 6415;
        
        
        public Types.GuildFactSheetInformations infos;
        public int creationDate;
        public ushort nbTaxCollectors;
        public IEnumerable<Types.CharacterMinimalInformations> members;
        
        public GuildFactsMessage()
        {
        }
        
        public GuildFactsMessage(Types.GuildFactSheetInformations infos, int creationDate, ushort nbTaxCollectors, IEnumerable<Types.CharacterMinimalInformations> members)
        {
            this.infos = infos;
            this.creationDate = creationDate;
            this.nbTaxCollectors = nbTaxCollectors;
            this.members = members;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
            writer.WriteInt(creationDate);
            writer.WriteVarShort((int)nbTaxCollectors);
            writer.WriteShort((short)members.Count());
            foreach (var entry in members)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            infos = ProtocolTypeManager.GetInstance<Types.GuildFactSheetInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
            creationDate = reader.ReadInt();
            nbTaxCollectors = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            members = new Types.CharacterMinimalInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (members as Types.CharacterMinimalInformations[])[i] = new Types.CharacterMinimalInformations();
                 (members as Types.CharacterMinimalInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}