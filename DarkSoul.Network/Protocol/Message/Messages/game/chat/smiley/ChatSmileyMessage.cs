

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ChatSmileyMessage : NetworkMessage
    {
        public override ushort Id => 801;
        
        
        public double entityId;
        public ushort smileyId;
        public int accountId;
        
        public ChatSmileyMessage()
        {
        }
        
        public ChatSmileyMessage(double entityId, ushort smileyId, int accountId)
        {
            this.entityId = entityId;
            this.smileyId = smileyId;
            this.accountId = accountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(entityId);
            writer.WriteVarShort((int)smileyId);
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            entityId = reader.ReadDouble();
            smileyId = reader.ReadVarUhShort();
            accountId = reader.ReadInt();
        }
        
    }
    
}