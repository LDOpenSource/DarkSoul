

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
    public class SymbioticObjectAssociateRequestMessage : NetworkMessage
    {
        public override ushort Id => 6522;
        
        
        public uint symbioteUID;
        public byte symbiotePos;
        public uint hostUID;
        public byte hostPos;
        
        public SymbioticObjectAssociateRequestMessage()
        {
        }
        
        public SymbioticObjectAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos)
        {
            this.symbioteUID = symbioteUID;
            this.symbiotePos = symbiotePos;
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)symbioteUID);
            writer.WriteByte(symbiotePos);
            writer.WriteVarInt((int)hostUID);
            writer.WriteByte(hostPos);
        }
        
        public override void Deserialize(IReader reader)
        {
            symbioteUID = reader.ReadVarUhInt();
            symbiotePos = reader.ReadByte();
            hostUID = reader.ReadVarUhInt();
            hostPos = reader.ReadByte();
        }
        
    }
    
}