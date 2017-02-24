

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildPaddockBoughtMessage : NetworkMessage
    {
        public override ushort Id => 5952;
        
        
        public Types.PaddockContentInformations paddockInfo;
        
        public GuildPaddockBoughtMessage()
        {
        }
        
        public GuildPaddockBoughtMessage(Types.PaddockContentInformations paddockInfo)
        {
            this.paddockInfo = paddockInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            paddockInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            paddockInfo = new Types.PaddockContentInformations();
            paddockInfo.Deserialize(reader);
        }
        
    }
    
}