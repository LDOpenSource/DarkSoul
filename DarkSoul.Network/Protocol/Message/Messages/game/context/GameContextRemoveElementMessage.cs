

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
    public class GameContextRemoveElementMessage : NetworkMessage
    {
        public override ushort Id => 251;
        
        
        public double id;
        
        public GameContextRemoveElementMessage()
        {
        }
        
        public GameContextRemoveElementMessage(double id)
        {
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
        }
        
    }
    
}