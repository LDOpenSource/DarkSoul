

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ArenaFighterLeaveMessage : NetworkMessage
    {
        public override ushort Id => 6700;
        
        
        public Types.CharacterBasicMinimalInformations leaver;
        
        public ArenaFighterLeaveMessage()
        {
        }
        
        public ArenaFighterLeaveMessage(Types.CharacterBasicMinimalInformations leaver)
        {
            this.leaver = leaver;
        }
        
        public override void Serialize(IWriter writer)
        {
            leaver.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            leaver = new Types.CharacterBasicMinimalInformations();
            leaver.Deserialize(reader);
        }
        
    }
    
}