

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightOptionToggleMessage : NetworkMessage
    {
        public override ushort Id => 707;
        
        
        public sbyte option;
        
        public GameFightOptionToggleMessage()
        {
        }
        
        public GameFightOptionToggleMessage(sbyte option)
        {
            this.option = option;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(option);
        }
        
        public override void Deserialize(IReader reader)
        {
            option = reader.ReadSByte();
        }
        
    }
    
}