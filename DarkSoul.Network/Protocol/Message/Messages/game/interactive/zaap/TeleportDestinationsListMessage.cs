

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportDestinationsListMessage : NetworkMessage
    {
        public override ushort Id => 5960;
        
        
        public sbyte teleporterType;
        public IEnumerable<int> mapIds;
        public IEnumerable<ushort> subAreaIds;
        public IEnumerable<ushort> costs;
        public IEnumerable<sbyte> destTeleporterType;
        
        public TeleportDestinationsListMessage()
        {
        }
        
        public TeleportDestinationsListMessage(sbyte teleporterType, IEnumerable<int> mapIds, IEnumerable<ushort> subAreaIds, IEnumerable<ushort> costs, IEnumerable<sbyte> destTeleporterType)
        {
            this.teleporterType = teleporterType;
            this.mapIds = mapIds;
            this.subAreaIds = subAreaIds;
            this.costs = costs;
            this.destTeleporterType = destTeleporterType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(teleporterType);
            writer.WriteShort((short)mapIds.Count());
            foreach (var entry in mapIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)subAreaIds.Count());
            foreach (var entry in subAreaIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)costs.Count());
            foreach (var entry in costs)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)destTeleporterType.Count());
            foreach (var entry in destTeleporterType)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            teleporterType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            mapIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (mapIds as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            subAreaIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (subAreaIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            costs = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (costs as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            destTeleporterType = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (destTeleporterType as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}