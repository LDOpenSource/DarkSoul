

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
    {
        public override ushort Id => 5691;
        
        
        public IEnumerable<double> actorIds;
        
        public EmotePlayMassiveMessage()
        {
        }
        
        public EmotePlayMassiveMessage(byte emoteId, double emoteStartTime, IEnumerable<double> actorIds)
         : base(emoteId, emoteStartTime)
        {
            this.actorIds = actorIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)actorIds.Count());
            foreach (var entry in actorIds)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            actorIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (actorIds as double[])[i] = reader.ReadDouble();
            }
        }
        
    }
    
}