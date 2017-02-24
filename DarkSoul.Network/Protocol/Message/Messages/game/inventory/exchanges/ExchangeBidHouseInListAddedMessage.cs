

// Generated on 02/23/2017 16:53:52
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeBidHouseInListAddedMessage : NetworkMessage
    {
        public override ushort Id => 5949;
        
        
        public int itemUID;
        public int objGenericId;
        public IEnumerable<Types.ObjectEffect> effects;
        public IEnumerable<double> prices;
        
        public ExchangeBidHouseInListAddedMessage()
        {
        }
        
        public ExchangeBidHouseInListAddedMessage(int itemUID, int objGenericId, IEnumerable<Types.ObjectEffect> effects, IEnumerable<double> prices)
        {
            this.itemUID = itemUID;
            this.objGenericId = objGenericId;
            this.effects = effects;
            this.prices = prices;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(itemUID);
            writer.WriteInt(objGenericId);
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
        
        public override void Deserialize(IReader reader)
        {
            itemUID = reader.ReadInt();
            objGenericId = reader.ReadInt();
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