

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LivingObjectMessageMessage : NetworkMessage
    {
        public override ushort Id => 6065;
        
        
        public ushort msgId;
        public int timeStamp;
        public string owner;
        public ushort objectGenericId;
        
        public LivingObjectMessageMessage()
        {
        }
        
        public LivingObjectMessageMessage(ushort msgId, int timeStamp, string owner, ushort objectGenericId)
        {
            this.msgId = msgId;
            this.timeStamp = timeStamp;
            this.owner = owner;
            this.objectGenericId = objectGenericId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)msgId);
            writer.WriteInt(timeStamp);
            writer.WriteUTF(owner);
            writer.WriteVarShort((int)objectGenericId);
        }
        
        public override void Deserialize(IReader reader)
        {
            msgId = reader.ReadVarUhShort();
            timeStamp = reader.ReadInt();
            owner = reader.ReadUTF();
            objectGenericId = reader.ReadVarUhShort();
        }
        
    }
    
}