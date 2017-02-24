

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
    public class ZaapListMessage : TeleportDestinationsListMessage
    {
        public override ushort Id => 1604;
        
        
        public int spawnMapId;
        
        public ZaapListMessage()
        {
        }
        
        public ZaapListMessage(sbyte teleporterType, IEnumerable<int> mapIds, IEnumerable<ushort> subAreaIds, IEnumerable<ushort> costs, IEnumerable<sbyte> destTeleporterType, int spawnMapId)
         : base(teleporterType, mapIds, subAreaIds, costs, destTeleporterType)
        {
            this.spawnMapId = spawnMapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(spawnMapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            spawnMapId = reader.ReadInt();
        }
        
    }
    
}