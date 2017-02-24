

// Generated on 02/23/2017 16:53:33
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayShowMultipleActorsMessage : NetworkMessage
    {
        public override ushort Id => 6712;
        
        
        public IEnumerable<Types.GameRolePlayActorInformations> informationsList;
        
        public GameRolePlayShowMultipleActorsMessage()
        {
        }
        
        public GameRolePlayShowMultipleActorsMessage(IEnumerable<Types.GameRolePlayActorInformations> informationsList)
        {
            this.informationsList = informationsList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)informationsList.Count());
            foreach (var entry in informationsList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            informationsList = new Types.GameRolePlayActorInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (informationsList as Types.GameRolePlayActorInformations[])[i] = new Types.GameRolePlayActorInformations();
                 (informationsList as Types.GameRolePlayActorInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}