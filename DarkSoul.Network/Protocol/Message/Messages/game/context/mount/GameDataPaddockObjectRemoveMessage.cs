

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameDataPaddockObjectRemoveMessage : NetworkMessage
    {
        public override ushort Id => 5993;
        
        
        public ushort cellId;
        
        public GameDataPaddockObjectRemoveMessage()
        {
        }
        
        public GameDataPaddockObjectRemoveMessage(ushort cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IReader reader)
        {
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}