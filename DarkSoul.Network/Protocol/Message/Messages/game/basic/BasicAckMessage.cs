

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicAckMessage : NetworkMessage
    {
        public override ushort Id => 6362;
        
        
        public uint seq;
        public ushort lastPacketId;
        
        public BasicAckMessage()
        {
        }
        
        public BasicAckMessage(uint seq, ushort lastPacketId)
        {
            this.seq = seq;
            this.lastPacketId = lastPacketId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)seq);
            writer.WriteVarShort((int)lastPacketId);
        }
        
        public override void Deserialize(IReader reader)
        {
            seq = reader.ReadVarUhInt();
            lastPacketId = reader.ReadVarUhShort();
        }
        
    }
    
}