

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightSynchronizeMessage : NetworkMessage
    {
        public override ushort Id => 5921;
        
        
        public IEnumerable<Types.GameFightFighterInformations> fighters;
        
        public GameFightSynchronizeMessage()
        {
        }
        
        public GameFightSynchronizeMessage(IEnumerable<Types.GameFightFighterInformations> fighters)
        {
            this.fighters = fighters;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)fighters.Count());
            foreach (var entry in fighters)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            fighters = new Types.GameFightFighterInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fighters as Types.GameFightFighterInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GameFightFighterInformations>(reader.ReadUShort());
                 (fighters as Types.GameFightFighterInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}