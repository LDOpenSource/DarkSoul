

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class InteractiveUsedMessage : NetworkMessage
    {
        public override ushort Id => 5745;
        
        
        public double entityId;
        public uint elemId;
        public ushort skillId;
        public ushort duration;
        public bool canMove;
        
        public InteractiveUsedMessage()
        {
        }
        
        public InteractiveUsedMessage(double entityId, uint elemId, ushort skillId, ushort duration, bool canMove)
        {
            this.entityId = entityId;
            this.elemId = elemId;
            this.skillId = skillId;
            this.duration = duration;
            this.canMove = canMove;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(entityId);
            writer.WriteVarInt((int)elemId);
            writer.WriteVarShort((int)skillId);
            writer.WriteVarShort((int)duration);
            writer.WriteBoolean(canMove);
        }
        
        public override void Deserialize(IReader reader)
        {
            entityId = reader.ReadVarUhLong();
            elemId = reader.ReadVarUhInt();
            skillId = reader.ReadVarUhShort();
            duration = reader.ReadVarUhShort();
            canMove = reader.ReadBoolean();
        }
        
    }
    
}