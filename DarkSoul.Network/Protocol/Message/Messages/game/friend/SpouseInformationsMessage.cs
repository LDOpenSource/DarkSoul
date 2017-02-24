

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
    public class SpouseInformationsMessage : NetworkMessage
    {
        public override ushort Id => 6356;
        
        
        public Types.FriendSpouseInformations spouse;
        
        public SpouseInformationsMessage()
        {
        }
        
        public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            spouse = ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadUShort());
            spouse.Deserialize(reader);
        }
        
    }
    
}