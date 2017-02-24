

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
    public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
    {
        public override ushort Id => 6020;
        
        
        public bool allowed;
        
        public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
        {
        }
        
        public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
        {
            this.allowed = allowed;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(allowed);
        }
        
        public override void Deserialize(IReader reader)
        {
            allowed = reader.ReadBoolean();
        }
        
    }
    
}