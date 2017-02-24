

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightActivateGlyphTrapMessage : AbstractGameActionMessage
    {
        public override ushort Id => 6545;
        
        
        public short markId;
        public bool active;
        
        public GameActionFightActivateGlyphTrapMessage()
        {
        }
        
        public GameActionFightActivateGlyphTrapMessage(ushort actionId, double sourceId, short markId, bool active)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.active = active;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteBoolean(active);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            markId = reader.ReadShort();
            active = reader.ReadBoolean();
        }
        
    }
    
}