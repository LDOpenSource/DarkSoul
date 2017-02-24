

// Generated on 02/23/2017 16:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StorageKamasUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5645;
        
        
        public double kamasTotal;
        
        public StorageKamasUpdateMessage()
        {
        }
        
        public StorageKamasUpdateMessage(double kamasTotal)
        {
            this.kamasTotal = kamasTotal;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(kamasTotal);
        }
        
        public override void Deserialize(IReader reader)
        {
            kamasTotal = reader.ReadVarUhLong();
        }
        
    }
    
}