

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
    public class ChatServerCopyWithObjectMessage : ChatServerCopyMessage
    {
        public override ushort Id => 884;
        
        
        public IEnumerable<Types.ObjectItem> objects;
        
        public ChatServerCopyWithObjectMessage()
        {
        }
        
        public ChatServerCopyWithObjectMessage(sbyte channel, string content, int timestamp, string fingerprint, double receiverId, string receiverName, IEnumerable<Types.ObjectItem> objects)
         : base(channel, content, timestamp, fingerprint, receiverId, receiverName)
        {
            this.objects = objects;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)objects.Count());
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            objects = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objects as Types.ObjectItem[])[i] = new Types.ObjectItem();
                 (objects as Types.ObjectItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}