

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapRunningFightDetailsMessage : NetworkMessage
    {
        public override ushort Id => 5751;
        
        
        public int fightId;
        public IEnumerable<Types.GameFightFighterLightInformations> attackers;
        public IEnumerable<Types.GameFightFighterLightInformations> defenders;
        
        public MapRunningFightDetailsMessage()
        {
        }
        
        public MapRunningFightDetailsMessage(int fightId, IEnumerable<Types.GameFightFighterLightInformations> attackers, IEnumerable<Types.GameFightFighterLightInformations> defenders)
        {
            this.fightId = fightId;
            this.attackers = attackers;
            this.defenders = defenders;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteShort((short)attackers.Count());
            foreach (var entry in attackers)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)defenders.Count());
            foreach (var entry in defenders)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            var limit = reader.ReadUShort();
            attackers = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (attackers as Types.GameFightFighterLightInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterLightInformations>(reader.ReadUShort());
                 (attackers as Types.GameFightFighterLightInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            defenders = new Types.GameFightFighterLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (defenders as Types.GameFightFighterLightInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterLightInformations>(reader.ReadUShort());
                 (defenders as Types.GameFightFighterLightInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}