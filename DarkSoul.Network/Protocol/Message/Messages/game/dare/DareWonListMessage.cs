

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareWonListMessage : NetworkMessage
    {
        public override ushort Id => 0x1A1A;
        
        
        public IEnumerable<double> dareId;
        
        public DareWonListMessage()
        {
        }
        
        public DareWonListMessage(IEnumerable<double> dareId)
        {
            this.dareId = dareId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)dareId.Count());
            foreach (var entry in dareId)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            dareId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dareId as double[])[i] = reader.ReadDouble();
            }
        }
        
    }
    
}