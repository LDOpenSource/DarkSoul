

// Generated on 02/23/2017 16:53:28
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameEntityDispositionMessage : NetworkMessage
    {
        public override ushort Id => 5693;
        
        
        public Types.IdentifiedEntityDispositionInformations disposition;
        
        public GameEntityDispositionMessage()
        {
        }
        
        public GameEntityDispositionMessage(Types.IdentifiedEntityDispositionInformations disposition)
        {
            this.disposition = disposition;
        }
        
        public override void Serialize(IWriter writer)
        {
            disposition.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            disposition = new Types.IdentifiedEntityDispositionInformations();
            disposition.Deserialize(reader);
        }
        
    }
    
}