

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismFightAddedMessage : NetworkMessage
    {
        public override ushort Id => 6452;
        
        
        public Types.PrismFightersInformation fight;
        
        public PrismFightAddedMessage()
        {
        }
        
        public PrismFightAddedMessage(Types.PrismFightersInformation fight)
        {
            this.fight = fight;
        }
        
        public override void Serialize(IWriter writer)
        {
            fight.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            fight = new Types.PrismFightersInformation();
            fight.Deserialize(reader);
        }
        
    }
    
}