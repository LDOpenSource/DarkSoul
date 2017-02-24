

// Generated on 02/23/2017 16:53:28
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameContextMoveMultipleElementsMessage : NetworkMessage
    {
        public override ushort Id => 254;
        
        
        public IEnumerable<Types.EntityMovementInformations> movements;
        
        public GameContextMoveMultipleElementsMessage()
        {
        }
        
        public GameContextMoveMultipleElementsMessage(IEnumerable<Types.EntityMovementInformations> movements)
        {
            this.movements = movements;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)movements.Count());
            foreach (var entry in movements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            movements = new Types.EntityMovementInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (movements as Types.EntityMovementInformations[])[i] = new Types.EntityMovementInformations();
                 (movements as Types.EntityMovementInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}