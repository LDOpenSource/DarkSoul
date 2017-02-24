

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StatsUpgradeRequestMessage : NetworkMessage
    {
        public override ushort Id => 5610;
        
        
        public bool useAdditionnal;
        public sbyte statId;
        public ushort boostPoint;
        
        public StatsUpgradeRequestMessage()
        {
        }
        
        public StatsUpgradeRequestMessage(bool useAdditionnal, sbyte statId, ushort boostPoint)
        {
            this.useAdditionnal = useAdditionnal;
            this.statId = statId;
            this.boostPoint = boostPoint;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(useAdditionnal);
            writer.WriteSByte(statId);
            writer.WriteVarShort((int)boostPoint);
        }
        
        public override void Deserialize(IReader reader)
        {
            useAdditionnal = reader.ReadBoolean();
            statId = reader.ReadSByte();
            boostPoint = reader.ReadVarUhShort();
        }
        
    }
    
}