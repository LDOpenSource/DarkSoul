

// Generated on 02/23/2017 16:53:58
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
    {
        public override ushort Id => 6460;
        
        
        public uint foodUID;
        public byte foodPos;
        public bool preview;
        
        public MimicryObjectFeedAndAssociateRequestMessage()
        {
        }
        
        public MimicryObjectFeedAndAssociateRequestMessage(uint symbioteUID, byte symbiotePos, uint hostUID, byte hostPos, uint foodUID, byte foodPos, bool preview)
         : base(symbioteUID, symbiotePos, hostUID, hostPos)
        {
            this.foodUID = foodUID;
            this.foodPos = foodPos;
            this.preview = preview;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)foodUID);
            writer.WriteByte(foodPos);
            writer.WriteBoolean(preview);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            foodUID = reader.ReadVarUhInt();
            foodPos = reader.ReadByte();
            preview = reader.ReadBoolean();
        }
        
    }
    
}