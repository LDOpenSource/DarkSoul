

// Generated on 02/23/2017 16:53:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IgnoredDeleteRequestMessage : NetworkMessage
    {
        public override ushort Id => 5680;
        
        
        public int accountId;
        public bool session;
        
        public IgnoredDeleteRequestMessage()
        {
        }
        
        public IgnoredDeleteRequestMessage(int accountId, bool session)
        {
            this.accountId = accountId;
            this.session = session;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(accountId);
            writer.WriteBoolean(session);
        }
        
        public override void Deserialize(IReader reader)
        {
            accountId = reader.ReadInt();
            session = reader.ReadBoolean();
        }
        
    }
    
}