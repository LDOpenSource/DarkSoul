

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class RecycleResultMessage : NetworkMessage
    {
        public override ushort Id => 6601;
        
        
        public uint nuggetsForPrism;
        public uint nuggetsForPlayer;
        
        public RecycleResultMessage()
        {
        }
        
        public RecycleResultMessage(uint nuggetsForPrism, uint nuggetsForPlayer)
        {
            this.nuggetsForPrism = nuggetsForPrism;
            this.nuggetsForPlayer = nuggetsForPlayer;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)nuggetsForPrism);
            writer.WriteVarInt((int)nuggetsForPlayer);
        }
        
        public override void Deserialize(IReader reader)
        {
            nuggetsForPrism = reader.ReadVarUhInt();
            nuggetsForPlayer = reader.ReadVarUhInt();
        }
        
    }
    
}