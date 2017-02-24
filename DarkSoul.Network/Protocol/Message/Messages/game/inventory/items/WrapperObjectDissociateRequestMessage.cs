

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
    public class WrapperObjectDissociateRequestMessage : NetworkMessage
    {
        public override ushort Id => 6524;
        
        
        public uint hostUID;
        public byte hostPos;
        
        public WrapperObjectDissociateRequestMessage()
        {
        }
        
        public WrapperObjectDissociateRequestMessage(uint hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
        }
        
        public override void Deserialize(IReader reader)
        {
            hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
        }
        
    }
    
}