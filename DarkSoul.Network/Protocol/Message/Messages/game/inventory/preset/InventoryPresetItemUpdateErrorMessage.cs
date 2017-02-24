

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
    public class InventoryPresetItemUpdateErrorMessage : NetworkMessage
    {
        public override ushort Id => 6211;
        
        
        public sbyte code;
        
        public InventoryPresetItemUpdateErrorMessage()
        {
        }
        
        public InventoryPresetItemUpdateErrorMessage(sbyte code)
        {
            this.code = code;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(code);
        }
        
        public override void Deserialize(IReader reader)
        {
            code = reader.ReadSByte();
        }
        
    }
    
}