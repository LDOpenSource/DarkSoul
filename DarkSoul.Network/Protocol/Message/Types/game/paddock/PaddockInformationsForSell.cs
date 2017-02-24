

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockInformationsForSell
    {
        public virtual short TypeId => 222;
        
        public string guildOwner;
        public short worldX;
        public short worldY;
        public ushort subAreaId;
        public sbyte nbMount;
        public sbyte nbObject;
        public double price;
        
        public PaddockInformationsForSell()
        {
        }
        
        public PaddockInformationsForSell(string guildOwner, short worldX, short worldY, ushort subAreaId, sbyte nbMount, sbyte nbObject, double price)
        {
            this.guildOwner = guildOwner;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.nbMount = nbMount;
            this.nbObject = nbObject;
            this.price = price;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteUTF(guildOwner);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSByte(nbMount);
            writer.WriteSByte(nbObject);
            writer.WriteVarLong(price);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            guildOwner = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            subAreaId = reader.ReadVarUhShort();
            nbMount = reader.ReadSByte();
            nbObject = reader.ReadSByte();
            price = reader.ReadVarUhLong();
        }
        
    }
    
}