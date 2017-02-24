

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class EntityTalkMessage : NetworkMessage
    {
        public override ushort Id => 6110;
        
        
        public double entityId;
        public ushort textId;
        public IEnumerable<string> parameters;
        
        public EntityTalkMessage()
        {
        }
        
        public EntityTalkMessage(double entityId, ushort textId, IEnumerable<string> parameters)
        {
            this.entityId = entityId;
            this.textId = textId;
            this.parameters = parameters;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(entityId);
            writer.WriteVarShort((int)textId);
            writer.WriteShort((short)parameters.Count());
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            entityId = reader.ReadDouble();
            textId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (parameters as string[])[i] = reader.ReadUTF();
            }
        }
        
    }
    
}