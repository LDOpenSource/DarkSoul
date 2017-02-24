

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class LeaveDialogMessage : NetworkMessage
    {
        public override ushort Id => 5502;
        
        
        public sbyte dialogType;
        
        public LeaveDialogMessage()
        {
        }
        
        public LeaveDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(dialogType);
        }
        
        public override void Deserialize(IReader reader)
        {
            dialogType = reader.ReadSByte();
        }
        
    }
    
}