

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
    public class LockableStateUpdateAbstractMessage : NetworkMessage
    {
        public override ushort Id => 5671;
        
        
        public bool locked;
        
        public LockableStateUpdateAbstractMessage()
        {
        }
        
        public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(locked);
        }
        
        public override void Deserialize(IReader reader)
        {
            locked = reader.ReadBoolean();
        }
        
    }
    
}