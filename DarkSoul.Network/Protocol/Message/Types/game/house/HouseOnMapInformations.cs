

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseOnMapInformations : HouseInformations
    {
        public override short TypeId => 510;
        
        public IEnumerable<int> doorsOnMap;
        public IEnumerable<Types.HouseInstanceInformations> houseInstances;
        
        public HouseOnMapInformations()
        {
        }
        
        public HouseOnMapInformations(uint houseId, ushort modelId, IEnumerable<int> doorsOnMap, IEnumerable<Types.HouseInstanceInformations> houseInstances)
         : base(houseId, modelId)
        {
            this.doorsOnMap = doorsOnMap;
            this.houseInstances = houseInstances;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)doorsOnMap.Count());
            foreach (var entry in doorsOnMap)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)houseInstances.Count());
            foreach (var entry in houseInstances)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            doorsOnMap = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (doorsOnMap as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            houseInstances = new Types.HouseInstanceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (houseInstances as Types.HouseInstanceInformations[])[i] = new Types.HouseInstanceInformations();
                 (houseInstances as Types.HouseInstanceInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}