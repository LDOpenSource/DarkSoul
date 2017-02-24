

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildCharacsUpgradeRequestMessage : NetworkMessage
    {
        public override ushort Id => 5706;
        
        
        public sbyte charaTypeTarget;
        
        public GuildCharacsUpgradeRequestMessage()
        {
        }
        
        public GuildCharacsUpgradeRequestMessage(sbyte charaTypeTarget)
        {
            this.charaTypeTarget = charaTypeTarget;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(charaTypeTarget);
        }
        
        public override void Deserialize(IReader reader)
        {
            charaTypeTarget = reader.ReadSByte();
        }
        
    }
    
}