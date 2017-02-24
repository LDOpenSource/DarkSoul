

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SystemMessageDisplayMessage : NetworkMessage
    {
        public override ushort Id => 189;
        
        
        public bool hangUp;
        public ushort msgId;
        public IEnumerable<string> parameters;
        
        public SystemMessageDisplayMessage()
        {
        }
        
        public SystemMessageDisplayMessage(bool hangUp, ushort msgId, IEnumerable<string> parameters)
        {
            this.hangUp = hangUp;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(hangUp);
            writer.WriteVarShort((int)msgId);
            writer.WriteShort((short)parameters.Count());
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            hangUp = reader.ReadBoolean();
            msgId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (parameters as string[])[i] = reader.ReadUTF();
            }
        }
        
    }
    
}