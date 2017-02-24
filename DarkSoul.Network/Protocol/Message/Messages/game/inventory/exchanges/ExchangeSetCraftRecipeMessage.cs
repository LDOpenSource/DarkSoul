

// Generated on 02/23/2017 16:53:55
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ExchangeSetCraftRecipeMessage : NetworkMessage
    {
        public override ushort Id => 6389;
        
        
        public ushort objectGID;
        
        public ExchangeSetCraftRecipeMessage()
        {
        }
        
        public ExchangeSetCraftRecipeMessage(ushort objectGID)
        {
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)objectGID);
        }
        
        public override void Deserialize(IReader reader)
        {
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}