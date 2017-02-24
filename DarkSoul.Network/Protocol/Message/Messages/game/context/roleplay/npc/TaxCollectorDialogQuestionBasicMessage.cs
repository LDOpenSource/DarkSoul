

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TaxCollectorDialogQuestionBasicMessage : NetworkMessage
    {
        public override ushort Id => 5619;
        
        
        public Types.BasicGuildInformations guildInfo;
        
        public TaxCollectorDialogQuestionBasicMessage()
        {
        }
        
        public TaxCollectorDialogQuestionBasicMessage(Types.BasicGuildInformations guildInfo)
        {
            this.guildInfo = guildInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            guildInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
        }
        
    }
    
}