

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ClientUIOpenedByObjectMessage : ClientUIOpenedMessage
    {
        public override ushort Id => 6463;
        
        
        public uint uid;
        
        public ClientUIOpenedByObjectMessage()
        {
        }
        
        public ClientUIOpenedByObjectMessage(sbyte type, uint uid)
         : base(type)
        {
            this.uid = uid;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)uid);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            uid = reader.ReadVarUhInt();
        }
        
    }
    
}