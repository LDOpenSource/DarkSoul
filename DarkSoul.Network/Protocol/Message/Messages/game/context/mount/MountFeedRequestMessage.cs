

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MountFeedRequestMessage : NetworkMessage
    {
        public override ushort Id => 6189;
        
        
        public uint mountUid;
        public sbyte mountLocation;
        public uint mountFoodUid;
        public uint quantity;
        
        public MountFeedRequestMessage()
        {
        }
        
        public MountFeedRequestMessage(uint mountUid, sbyte mountLocation, uint mountFoodUid, uint quantity)
        {
            this.mountUid = mountUid;
            this.mountLocation = mountLocation;
            this.mountFoodUid = mountFoodUid;
            this.quantity = quantity;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)mountUid);
            writer.WriteSByte(mountLocation);
            writer.WriteVarInt((int)mountFoodUid);
            writer.WriteVarInt((int)quantity);
        }
        
        public override void Deserialize(IReader reader)
        {
            mountUid = reader.ReadVarUhInt();
            mountLocation = reader.ReadSByte();
            mountFoodUid = reader.ReadVarUhInt();
            quantity = reader.ReadVarUhInt();
        }
        
    }
    
}