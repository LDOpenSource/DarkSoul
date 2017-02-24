

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SymbioticObjectAssociatedMessage : NetworkMessage
    {
        public override ushort Id => 6527;
        
        
        public uint hostUID;
        
        public SymbioticObjectAssociatedMessage()
        {
        }
        
        public SymbioticObjectAssociatedMessage(uint hostUID)
        {
            this.hostUID = hostUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)hostUID);
        }
        
        public override void Deserialize(IReader reader)
        {
            hostUID = reader.ReadVarUhInt();
        }
        
    }
    
}