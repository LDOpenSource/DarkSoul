

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TaxCollectorAttackedMessage : NetworkMessage
    {
        public override ushort Id => 5918;
        
        
        public ushort firstNameId;
        public ushort lastNameId;
        public short worldX;
        public short worldY;
        public int mapId;
        public ushort subAreaId;
        public Types.BasicGuildInformations guild;
        
        public TaxCollectorAttackedMessage()
        {
        }
        
        public TaxCollectorAttackedMessage(ushort firstNameId, ushort lastNameId, short worldX, short worldY, int mapId, ushort subAreaId, Types.BasicGuildInformations guild)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.guild = guild;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
            guild.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
        }
        
    }
    
}