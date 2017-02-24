

// Generated on 02/23/2017 16:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterSelectedSuccessMessage : NetworkMessage
    {
        public override ushort Id => 153;
        
        
        public Types.CharacterBaseInformations infos;
        public bool isCollectingStats;
        
        public CharacterSelectedSuccessMessage()
        {
        }
        
        public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos, bool isCollectingStats)
        {
            this.infos = infos;
            this.isCollectingStats = isCollectingStats;
        }
        
        public override void Serialize(IWriter writer)
        {
            infos.Serialize(writer);
            writer.WriteBoolean(isCollectingStats);
        }
        
        public override void Deserialize(IReader reader)
        {
            infos = new Types.CharacterBaseInformations();
            infos.Deserialize(reader);
            isCollectingStats = reader.ReadBoolean();
        }
        
    }
    
}