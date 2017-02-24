

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class JobBookSubscriptionMessage : NetworkMessage
    {
        public override ushort Id => 6593;
        
        
        public IEnumerable<Types.JobBookSubscription> subscriptions;
        
        public JobBookSubscriptionMessage()
        {
        }
        
        public JobBookSubscriptionMessage(IEnumerable<Types.JobBookSubscription> subscriptions)
        {
            this.subscriptions = subscriptions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)subscriptions.Count());
            foreach (var entry in subscriptions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            subscriptions = new Types.JobBookSubscription[limit];
            for (int i = 0; i < limit; i++)
            {
                 (subscriptions as Types.JobBookSubscription[])[i] = new Types.JobBookSubscription();
                 (subscriptions as Types.JobBookSubscription[])[i].Deserialize(reader);
            }
        }
        
    }
    
}