

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightCastRequestMessage : NetworkMessage
    {
        public override ushort Id => 1005;
        
        
        public ushort spellId;
        public short cellId;
        
        public GameActionFightCastRequestMessage()
        {
        }
        
        public GameActionFightCastRequestMessage(ushort spellId, short cellId)
        {
            this.spellId = spellId;
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellId = reader.ReadVarUhShort();
            cellId = reader.ReadShort();
        }
        
    }
    
}