

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
    {
        public override ushort Id => 5668;
        
        
        public uint houseId;
        public uint instanceId;
        public bool secondHand;
        
        public LockableStateUpdateHouseDoorMessage()
        {
        }
        
        public LockableStateUpdateHouseDoorMessage(bool locked, uint houseId, uint instanceId, bool secondHand)
         : base(locked)
        {
            this.houseId = houseId;
            this.instanceId = instanceId;
            this.secondHand = secondHand;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)houseId);
            writer.WriteUInt(instanceId);
            writer.WriteBoolean(secondHand);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            houseId = reader.ReadVarUhInt();
            instanceId = reader.ReadUInt();
            secondHand = reader.ReadBoolean();
        }
        
    }
    
}