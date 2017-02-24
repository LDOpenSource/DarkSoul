

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class StartupActionsListMessage : NetworkMessage
    {
        public override ushort Id => 1301;
        
        
        public IEnumerable<Types.StartupActionAddObject> actions;
        
        public StartupActionsListMessage()
        {
        }
        
        public StartupActionsListMessage(IEnumerable<Types.StartupActionAddObject> actions)
        {
            this.actions = actions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)actions.Count());
            foreach (var entry in actions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            actions = new Types.StartupActionAddObject[limit];
            for (int i = 0; i < limit; i++)
            {
                 (actions as Types.StartupActionAddObject[])[i] = new Types.StartupActionAddObject();
                 (actions as Types.StartupActionAddObject[])[i].Deserialize(reader);
            }
        }
        
    }
    
}