

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
    public class GameContextRefreshEntityLookMessage : NetworkMessage
    {
        public override ushort Id => 5637;
        
        
        public double id;
        public Types.EntityLook look;
        
        public GameContextRefreshEntityLookMessage()
        {
        }
        
        public GameContextRefreshEntityLookMessage(double id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(id);
            look.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadDouble();
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}