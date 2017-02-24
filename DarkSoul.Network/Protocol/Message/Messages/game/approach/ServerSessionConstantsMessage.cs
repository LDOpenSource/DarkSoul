

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
    public class ServerSessionConstantsMessage : NetworkMessage
    {
        public override ushort Id => 6434;
        
        
        public IEnumerable<Types.ServerSessionConstant> variables;
        
        public ServerSessionConstantsMessage()
        {
        }
        
        public ServerSessionConstantsMessage(IEnumerable<Types.ServerSessionConstant> variables)
        {
            this.variables = variables;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)variables.Count());
            foreach (var entry in variables)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            variables = new Types.ServerSessionConstant[limit];
            for (int i = 0; i < limit; i++)
            {
                 (variables as Types.ServerSessionConstant[])[i] = ProtocolTypeManager.GetInstance<Types.ServerSessionConstant>(reader.ReadUShort());
                 (variables as Types.ServerSessionConstant[])[i].Deserialize(reader);
            }
        }
        
    }
    
}