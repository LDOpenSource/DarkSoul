

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TextInformationMessage : NetworkMessage
    {
        public override ushort Id => 780;
        
        
        public sbyte msgType;
        public ushort msgId;
        public IEnumerable<string> parameters;
        
        public TextInformationMessage()
        {
        }
        
        public TextInformationMessage(sbyte msgType, ushort msgId, IEnumerable<string> parameters)
        {
            this.msgType = msgType;
            this.msgId = msgId;
            this.parameters = parameters;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(msgType);
            writer.WriteVarShort((int)msgId);
            writer.WriteShort((short)parameters.Count());
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            msgType = reader.ReadSByte();
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