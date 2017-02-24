

// Generated on 02/23/2017 16:53:19
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
    {
        public override ushort Id => 5540;
        
        
        public Types.GameActionMark mark;
        
        public GameActionFightMarkCellsMessage()
        {
        }
        
        public GameActionFightMarkCellsMessage(ushort actionId, double sourceId, Types.GameActionMark mark)
         : base(actionId, sourceId)
        {
            this.mark = mark;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            mark.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            mark = new Types.GameActionMark();
            mark.Deserialize(reader);
        }
        
    }
    
}