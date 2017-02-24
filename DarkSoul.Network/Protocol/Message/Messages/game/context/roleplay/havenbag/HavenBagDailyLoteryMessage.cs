

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class HavenBagDailyLoteryMessage : NetworkMessage
    {
        public override ushort Id => 6644;
        
        
        public string tokenId;
        
        public HavenBagDailyLoteryMessage()
        {
        }
        
        public HavenBagDailyLoteryMessage(string tokenId)
        {
            this.tokenId = tokenId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(tokenId);
        }
        
        public override void Deserialize(IReader reader)
        {
            tokenId = reader.ReadUTF();
        }
        
    }
    
}