

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HousePropertiesMessage : NetworkMessage
    {
        public override ushort Id => 5734;
        
        
        public uint houseId;
        public IEnumerable<int> doorsOnMap;
        public Types.HouseInstanceInformations properties;
        
        public HousePropertiesMessage()
        {
        }
        
        public HousePropertiesMessage(uint houseId, IEnumerable<int> doorsOnMap, Types.HouseInstanceInformations properties)
        {
            this.houseId = houseId;
            this.doorsOnMap = doorsOnMap;
            this.properties = properties;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)houseId);
            writer.WriteShort((short)doorsOnMap.Count());
            foreach (var entry in doorsOnMap)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort(properties.TypeId);
            properties.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            houseId = reader.ReadVarUhInt();
            var limit = reader.ReadUShort();
            doorsOnMap = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (doorsOnMap as int[])[i] = reader.ReadInt();
            }
            properties = ProtocolTypeManager.GetInstance<Types.HouseInstanceInformations>(reader.ReadUShort());
            properties.Deserialize(reader);
        }
        
    }
    
}