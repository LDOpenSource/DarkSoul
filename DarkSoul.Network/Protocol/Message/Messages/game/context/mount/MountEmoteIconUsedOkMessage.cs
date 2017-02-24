

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
    public class MountEmoteIconUsedOkMessage : NetworkMessage
    {
        public override ushort Id => 5978;
        
        
        public int mountId;
        public sbyte reactionType;
        
        public MountEmoteIconUsedOkMessage()
        {
        }
        
        public MountEmoteIconUsedOkMessage(int mountId, sbyte reactionType)
        {
            this.mountId = mountId;
            this.reactionType = reactionType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)mountId);
            writer.WriteSByte(reactionType);
        }
        
        public override void Deserialize(IReader reader)
        {
            mountId = reader.ReadVarInt();
            reactionType = reader.ReadSByte();
        }
        
    }
    
}