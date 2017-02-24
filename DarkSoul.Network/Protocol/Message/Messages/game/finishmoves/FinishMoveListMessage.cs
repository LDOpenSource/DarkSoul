

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class FinishMoveListMessage : NetworkMessage
    {
        public override ushort Id => 6704;
        
        
        public IEnumerable<Types.FinishMoveInformations> finishMoves;
        
        public FinishMoveListMessage()
        {
        }
        
        public FinishMoveListMessage(IEnumerable<Types.FinishMoveInformations> finishMoves)
        {
            this.finishMoves = finishMoves;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)finishMoves.Count());
            foreach (var entry in finishMoves)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            finishMoves = new Types.FinishMoveInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (finishMoves as Types.FinishMoveInformations[])[i] = new Types.FinishMoveInformations();
                 (finishMoves as Types.FinishMoveInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}