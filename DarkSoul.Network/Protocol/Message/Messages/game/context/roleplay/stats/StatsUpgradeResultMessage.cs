

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
    public class StatsUpgradeResultMessage : NetworkMessage
    {
        public override ushort Id => 5609;
        
        
        public sbyte result;
        public ushort nbCharacBoost;
        
        public StatsUpgradeResultMessage()
        {
        }
        
        public StatsUpgradeResultMessage(sbyte result, ushort nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(result);
            writer.WriteVarShort((int)nbCharacBoost);
        }
        
        public override void Deserialize(IReader reader)
        {
            result = reader.ReadSByte();
            nbCharacBoost = reader.ReadVarUhShort();
        }
        
    }
    
}