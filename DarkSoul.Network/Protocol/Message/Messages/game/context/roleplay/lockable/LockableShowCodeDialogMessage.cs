

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
    public class LockableShowCodeDialogMessage : NetworkMessage
    {
        public override ushort Id => 5740;
        
        
        public bool changeOrUse;
        public sbyte codeSize;
        
        public LockableShowCodeDialogMessage()
        {
        }
        
        public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(changeOrUse);
            writer.WriteSByte(codeSize);
        }
        
        public override void Deserialize(IReader reader)
        {
            changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSByte();
        }
        
    }
    
}