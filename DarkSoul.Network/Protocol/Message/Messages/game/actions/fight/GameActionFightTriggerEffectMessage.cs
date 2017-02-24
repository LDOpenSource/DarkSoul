

// Generated on 02/23/2017 16:53:20
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightTriggerEffectMessage : GameActionFightDispellEffectMessage
    {
        public override ushort Id => 6147;
        
        
        
        public GameActionFightTriggerEffectMessage()
        {
        }
        
        public GameActionFightTriggerEffectMessage(ushort actionId, double sourceId, double targetId, int boostUID)
         : base(actionId, sourceId, targetId, boostUID)
        {
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}