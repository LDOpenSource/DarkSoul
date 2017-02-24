

// Generated on 02/23/2017 16:53:20
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightTackledMessage : AbstractGameActionMessage
    {
        public override ushort Id => 1004;
        
        
        public IEnumerable<double> tacklersIds;
        
        public GameActionFightTackledMessage()
        {
        }
        
        public GameActionFightTackledMessage(ushort actionId, double sourceId, IEnumerable<double> tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)tacklersIds.Count());
            foreach (var entry in tacklersIds)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            tacklersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (tacklersIds as double[])[i] = reader.ReadDouble();
            }
        }
        
    }
    
}