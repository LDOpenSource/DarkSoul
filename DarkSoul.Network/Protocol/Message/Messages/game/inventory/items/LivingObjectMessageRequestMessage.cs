

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
    public class LivingObjectMessageRequestMessage : NetworkMessage
    {
        public override ushort Id => 6066;
        
        
        public ushort msgId;
        public IEnumerable<string> parameters;
        public uint livingObject;
        
        public LivingObjectMessageRequestMessage()
        {
        }
        
        public LivingObjectMessageRequestMessage(ushort msgId, IEnumerable<string> parameters, uint livingObject)
        {
            this.msgId = msgId;
            this.parameters = parameters;
            this.livingObject = livingObject;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)msgId);
            writer.WriteShort((short)parameters.Count());
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteVarInt((int)livingObject);
        }
        
        public override void Deserialize(IReader reader)
        {
            msgId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (parameters as string[])[i] = reader.ReadUTF();
            }
            livingObject = reader.ReadVarUhInt();
        }
        
    }
    
}