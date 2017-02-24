

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRefreshMonsterBoostsMessage : NetworkMessage
    {
        public override ushort Id => 6618;
        
        
        public IEnumerable<Types.MonsterBoosts> monsterBoosts;
        public IEnumerable<Types.MonsterBoosts> familyBoosts;
        
        public GameRefreshMonsterBoostsMessage()
        {
        }
        
        public GameRefreshMonsterBoostsMessage(IEnumerable<Types.MonsterBoosts> monsterBoosts, IEnumerable<Types.MonsterBoosts> familyBoosts)
        {
            this.monsterBoosts = monsterBoosts;
            this.familyBoosts = familyBoosts;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)monsterBoosts.Count());
            foreach (var entry in monsterBoosts)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)familyBoosts.Count());
            foreach (var entry in familyBoosts)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            monsterBoosts = new Types.MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 (monsterBoosts as Types.MonsterBoosts[])[i] = new Types.MonsterBoosts();
                 (monsterBoosts as Types.MonsterBoosts[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            familyBoosts = new Types.MonsterBoosts[limit];
            for (int i = 0; i < limit; i++)
            {
                 (familyBoosts as Types.MonsterBoosts[])[i] = new Types.MonsterBoosts();
                 (familyBoosts as Types.MonsterBoosts[])[i].Deserialize(reader);
            }
        }
        
    }
    
}