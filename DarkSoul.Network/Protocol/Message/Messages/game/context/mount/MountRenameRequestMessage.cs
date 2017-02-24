

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
    public class MountRenameRequestMessage : NetworkMessage
    {
        public override ushort Id => 5987;
        
        
        public string name;
        public int mountId;
        
        public MountRenameRequestMessage()
        {
        }
        
        public MountRenameRequestMessage(string name, int mountId)
        {
            this.name = name;
            this.mountId = mountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteVarInt((int)mountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            name = reader.ReadUTF();
            mountId = reader.ReadVarInt();
        }
        
    }
    
}