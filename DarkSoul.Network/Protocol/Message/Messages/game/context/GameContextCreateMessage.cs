

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
    public class GameContextCreateMessage : NetworkMessage
    {
        public override ushort Id => 200;
        
        
        public sbyte context;
        
        public GameContextCreateMessage()
        {
        }
        
        public GameContextCreateMessage(sbyte context)
        {
            this.context = context;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(context);
        }
        
        public override void Deserialize(IReader reader)
        {
            context = reader.ReadSByte();
        }
        
    }
    
}