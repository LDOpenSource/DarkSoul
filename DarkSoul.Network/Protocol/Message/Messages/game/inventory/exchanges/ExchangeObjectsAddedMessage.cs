

// Generated on 02/23/2017 16:53:54
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeObjectsAddedMessage : ExchangeObjectMessage
    {
        public override ushort Id => 6535;
        
        
        public IEnumerable<Types.ObjectItem> @object;
        
        public ExchangeObjectsAddedMessage()
        {
        }
        
        public ExchangeObjectsAddedMessage(bool remote, IEnumerable<Types.ObjectItem> @object)
         : base(remote)
        {
            this.@object = @object;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)@object.Count());
            foreach (var entry in @object)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            @object = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (@object as Types.ObjectItem[])[i] = new Types.ObjectItem();
                 (@object as Types.ObjectItem[])[i].Deserialize(reader);
            }
        }
        
    }
    
}