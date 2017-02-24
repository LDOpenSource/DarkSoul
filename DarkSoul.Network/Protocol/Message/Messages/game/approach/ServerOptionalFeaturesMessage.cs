

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
    public class ServerOptionalFeaturesMessage : NetworkMessage
    {
        public override ushort Id => 6305;
        
        
        public IEnumerable<sbyte> features;
        
        public ServerOptionalFeaturesMessage()
        {
        }
        
        public ServerOptionalFeaturesMessage(IEnumerable<sbyte> features)
        {
            this.features = features;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)features.Count());
            foreach (var entry in features)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            features = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (features as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}