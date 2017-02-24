

// Generated on 02/23/2017 16:53:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IgnoredListMessage : NetworkMessage
    {
        public override ushort Id => 5674;
        
        
        public IEnumerable<Types.IgnoredInformations> ignoredList;
        
        public IgnoredListMessage()
        {
        }
        
        public IgnoredListMessage(IEnumerable<Types.IgnoredInformations> ignoredList)
        {
            this.ignoredList = ignoredList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)ignoredList.Count());
            foreach (var entry in ignoredList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            ignoredList = new Types.IgnoredInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ignoredList as Types.IgnoredInformations[])[i] = ProtocolTypeManager.GetInstance<Types.IgnoredInformations>(reader.ReadUShort());
                 (ignoredList as Types.IgnoredInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}