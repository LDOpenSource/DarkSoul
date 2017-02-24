

// Generated on 02/23/2017 16:53:20
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightSummonMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5825;
        
        
        public IEnumerable<Types.GameFightFighterInformations> summons;
        
        public GameActionFightSummonMessage()
        {
        }
        
        public GameActionFightSummonMessage(ushort actionId, double sourceId, IEnumerable<Types.GameFightFighterInformations> summons)
         : base(actionId, sourceId)
        {
            this.summons = summons;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)summons.Count());
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            summons = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (summons as Types.GameFightFighterInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadUShort());
                 (summons as Types.GameFightFighterInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}