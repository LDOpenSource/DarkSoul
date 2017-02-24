

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseInstanceInformations
    {
        public virtual short TypeId => 511;
        
        public bool secondHand;
        public bool isOnSale;
        public bool isSaleLocked;
        public uint instanceId;
        public string ownerName;
        
        public HouseInstanceInformations()
        {
        }
        
        public HouseInstanceInformations(bool secondHand, bool isOnSale, bool isSaleLocked, uint instanceId, string ownerName)
        {
            this.secondHand = secondHand;
            this.isOnSale = isOnSale;
            this.isSaleLocked = isSaleLocked;
            this.instanceId = instanceId;
            this.ownerName = ownerName;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, secondHand);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isOnSale);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, isSaleLocked);
            writer.WriteByte(flag1);
            writer.WriteUInt(instanceId);
            writer.WriteUTF(ownerName);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            secondHand = BooleanByteWrapper.GetFlag(flag1, 0);
            isOnSale = BooleanByteWrapper.GetFlag(flag1, 1);
            isSaleLocked = BooleanByteWrapper.GetFlag(flag1, 2);
            instanceId = reader.ReadUInt();
            ownerName = reader.ReadUTF();
        }
        
    }
    
}