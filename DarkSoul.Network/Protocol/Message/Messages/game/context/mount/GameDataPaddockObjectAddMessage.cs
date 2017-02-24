

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameDataPaddockObjectAddMessage : NetworkMessage
    {
        public override ushort Id => 5990;
        
        
        public Types.PaddockItem paddockItemDescription;
        
        public GameDataPaddockObjectAddMessage()
        {
        }
        
        public GameDataPaddockObjectAddMessage(Types.PaddockItem paddockItemDescription)
        {
            this.paddockItemDescription = paddockItemDescription;
        }
        
        public override void Serialize(IWriter writer)
        {
            paddockItemDescription.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            paddockItemDescription = new Types.PaddockItem();
            paddockItemDescription.Deserialize(reader);
        }
        
    }
    
}