

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ShortcutBarSwapRequestMessage : NetworkMessage
    {
        public override ushort Id => 6230;
        
        
        public sbyte barType;
        public sbyte firstSlot;
        public sbyte secondSlot;
        
        public ShortcutBarSwapRequestMessage()
        {
        }
        
        public ShortcutBarSwapRequestMessage(sbyte barType, sbyte firstSlot, sbyte secondSlot)
        {
            this.barType = barType;
            this.firstSlot = firstSlot;
            this.secondSlot = secondSlot;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(barType);
            writer.WriteSByte(firstSlot);
            writer.WriteSByte(secondSlot);
        }
        
        public override void Deserialize(IReader reader)
        {
            barType = reader.ReadSByte();
            firstSlot = reader.ReadSByte();
            secondSlot = reader.ReadSByte();
        }
        
    }
    
}