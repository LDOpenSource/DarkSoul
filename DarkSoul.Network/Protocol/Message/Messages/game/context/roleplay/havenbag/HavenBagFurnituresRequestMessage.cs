

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
    public class HavenBagFurnituresRequestMessage : NetworkMessage
    {
        public override ushort Id => 6637;
        
        
        public IEnumerable<ushort> cellIds;
        public IEnumerable<int> funitureIds;
        public IEnumerable<sbyte> orientations;
        
        public HavenBagFurnituresRequestMessage()
        {
        }
        
        public HavenBagFurnituresRequestMessage(IEnumerable<ushort> cellIds, IEnumerable<int> funitureIds, IEnumerable<sbyte> orientations)
        {
            this.cellIds = cellIds;
            this.funitureIds = funitureIds;
            this.orientations = orientations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)cellIds.Count());
            foreach (var entry in cellIds)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)funitureIds.Count());
            foreach (var entry in funitureIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)orientations.Count());
            foreach (var entry in orientations)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            cellIds = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (cellIds as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            funitureIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (funitureIds as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            orientations = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (orientations as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}