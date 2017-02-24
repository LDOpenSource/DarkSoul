

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
    public class MountRenamedMessage : NetworkMessage
    {
        public override ushort Id => 5983;
        
        
        public int mountId;
        public string name;
        
        public MountRenamedMessage()
        {
        }
        
        public MountRenamedMessage(int mountId, string name)
        {
            this.mountId = mountId;
            this.name = name;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)mountId);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IReader reader)
        {
            mountId = reader.ReadVarInt();
            name = reader.ReadUTF();
        }
        
    }
    
}