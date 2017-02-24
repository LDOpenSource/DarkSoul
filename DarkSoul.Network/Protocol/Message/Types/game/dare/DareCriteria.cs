

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class DareCriteria
    {
        public virtual short TypeId => 501;
        
        public sbyte type;
        public IEnumerable<int> @params;
        
        public DareCriteria()
        {
        }
        
        public DareCriteria(sbyte type, IEnumerable<int> @params)
        {
            this.type = type;
            this.@params = @params;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(type);
            writer.WriteShort((short)@params.Count());
            foreach (var entry in @params)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            type = reader.ReadSByte();
            var limit = reader.ReadUShort();
            @params = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (@params as int[])[i] = reader.ReadInt();
            }
        }
        
    }
    
}