

// Generated on 02/23/2017 16:53:53
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeGuildTaxCollectorGetMessage : NetworkMessage
    {
        public override ushort Id => 5762;
        
        
        public string collectorName;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public string userName;
        public double callerId;
        public string callerName;
        public double experience;
        public ushort pods;
        public IEnumerable<Types.ObjectItemGenericQuantity> objectsInfos;
        
        public ExchangeGuildTaxCollectorGetMessage()
        {
        }
        
        public ExchangeGuildTaxCollectorGetMessage(string collectorName, short worldX, short worldY, int mapId, ushort subAreaId, string userName, double callerId, string callerName, double experience, ushort pods, IEnumerable<Types.ObjectItemGenericQuantity> objectsInfos)
        {
            this.collectorName = collectorName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.userName = userName;
            this.callerId = callerId;
            this.callerName = callerName;
            this.experience = experience;
            this.pods = pods;
            this.objectsInfos = objectsInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(collectorName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteUTF(userName);
            writer.WriteVarLong(callerId);
            writer.WriteUTF(callerName);
            writer.WriteDouble(experience);
            writer.WriteVarShort((int)pods);
            writer.WriteShort((short)objectsInfos.Count());
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            collectorName = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            userName = reader.ReadUTF();
            callerId = reader.ReadVarUhLong();
            callerName = reader.ReadUTF();
            experience = reader.ReadDouble();
            pods = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItemGenericQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (objectsInfos as Types.ObjectItemGenericQuantity[])[i] = new Types.ObjectItemGenericQuantity();
                 (objectsInfos as Types.ObjectItemGenericQuantity[])[i].Deserialize(reader);
            }
        }
        
    }
    
}