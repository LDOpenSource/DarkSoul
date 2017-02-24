

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
    {
        public override ushort Id => 5885;
        
        
        
        public HouseLockFromInsideRequestMessage()
        {
        }
        
        public HouseLockFromInsideRequestMessage(string code)
         : base(code)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}