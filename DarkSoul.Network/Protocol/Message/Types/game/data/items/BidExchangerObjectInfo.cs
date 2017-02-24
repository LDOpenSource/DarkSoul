

// Generated on 02/23/2017 18:06:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class BidExchangerObjectInfo
    {
        public virtual short TypeId => 122;
        
        public uint objectUID;
        public IEnumerable<Types.ObjectEffect> effects;
        public IEnumerable<double> prices;
        
        public BidExchangerObjectInfo()
        {
        }
        
        public BidExchangerObjectInfo(uint objectUID, IEnumerable<Types.ObjectEffect> effects, IEnumerable<double> prices)
        {
            this.objectUID = objectUID;
            this.effects = effects;
            this.prices = prices;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)objectUID);
            writer.WriteShort((short)effects.Count());
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)prices.Count());
            foreach (var entry in prices)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            objectUID = reader.ReadVarUhInt();
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 (effects as Types.ObjectEffect[])[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 (effects as Types.ObjectEffect[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            prices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (prices as double[])[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}