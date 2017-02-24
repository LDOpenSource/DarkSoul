

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HavenBagFurnituresMessage : NetworkMessage
    {
        public override ushort Id => 6634;
        
        
        public IEnumerable<Types.HavenBagFurnitureInformation> furnituresInfos;
        
        public HavenBagFurnituresMessage()
        {
        }
        
        public HavenBagFurnituresMessage(IEnumerable<Types.HavenBagFurnitureInformation> furnituresInfos)
        {
            this.furnituresInfos = furnituresInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)furnituresInfos.Count());
            foreach (var entry in furnituresInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            furnituresInfos = new Types.HavenBagFurnitureInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (furnituresInfos as Types.HavenBagFurnitureInformation[])[i] = new Types.HavenBagFurnitureInformation();
                 (furnituresInfos as Types.HavenBagFurnitureInformation[])[i].Deserialize(reader);
            }
        }
        
    }
    
}