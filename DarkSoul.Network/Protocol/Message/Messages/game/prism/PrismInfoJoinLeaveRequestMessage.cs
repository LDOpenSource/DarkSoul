

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
    {
        public override ushort Id => 5844;
        
        
        public bool join;
        
        public PrismInfoJoinLeaveRequestMessage()
        {
        }
        
        public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            this.join = join;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(join);
        }
        
        public override void Deserialize(IReader reader)
        {
            join = reader.ReadBoolean();
        }
        
    }
    
}