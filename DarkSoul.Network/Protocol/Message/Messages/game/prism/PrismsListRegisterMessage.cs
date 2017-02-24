

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismsListRegisterMessage : NetworkMessage
    {
        public override ushort Id => 6441;
        
        
        public sbyte listen;
        
        public PrismsListRegisterMessage()
        {
        }
        
        public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(listen);
        }
        
        public override void Deserialize(IReader reader)
        {
            listen = reader.ReadSByte();
        }
        
    }
    
}