

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
    public class HouseToSellFilterMessage : NetworkMessage
    {
        public override ushort Id => 6137;
        
        
        public int areaId;
        public sbyte atLeastNbRoom;
        public sbyte atLeastNbChest;
        public ushort skillRequested;
        public double maxPrice;
        
        public HouseToSellFilterMessage()
        {
        }
        
        public HouseToSellFilterMessage(int areaId, sbyte atLeastNbRoom, sbyte atLeastNbChest, ushort skillRequested, double maxPrice)
        {
            this.areaId = areaId;
            this.atLeastNbRoom = atLeastNbRoom;
            this.atLeastNbChest = atLeastNbChest;
            this.skillRequested = skillRequested;
            this.maxPrice = maxPrice;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(areaId);
            writer.WriteSByte(atLeastNbRoom);
            writer.WriteSByte(atLeastNbChest);
            writer.WriteVarShort((int)skillRequested);
            writer.WriteVarLong(maxPrice);
        }
        
        public override void Deserialize(IReader reader)
        {
            areaId = reader.ReadInt();
            atLeastNbRoom = reader.ReadSByte();
            atLeastNbChest = reader.ReadSByte();
            skillRequested = reader.ReadVarUhShort();
            maxPrice = reader.ReadVarUhLong();
        }
        
    }
    
}