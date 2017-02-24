

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
    {
        public override ushort Id => 6021;
        
        
        public bool allow;
        
        public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
        {
        }
        
        public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
        {
            this.allow = allow;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(allow);
        }
        
        public override void Deserialize(IReader reader)
        {
            allow = reader.ReadBoolean();
        }
        
    }
    
}