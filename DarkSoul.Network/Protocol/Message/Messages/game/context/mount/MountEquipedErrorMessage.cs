

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
    public class MountEquipedErrorMessage : NetworkMessage
    {
        public override ushort Id => 5963;
        
        
        public sbyte errorType;
        
        public MountEquipedErrorMessage()
        {
        }
        
        public MountEquipedErrorMessage(sbyte errorType)
        {
            this.errorType = errorType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(errorType);
        }
        
        public override void Deserialize(IReader reader)
        {
            errorType = reader.ReadSByte();
        }
        
    }
    
}