

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterFirstSelectionMessage : CharacterSelectionMessage
    {
        public override ushort Id => 6084;
        
        
        public bool doTutorial;
        
        public CharacterFirstSelectionMessage()
        {
        }
        
        public CharacterFirstSelectionMessage(double id, bool doTutorial)
         : base(id)
        {
            this.doTutorial = doTutorial;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(doTutorial);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            doTutorial = reader.ReadBoolean();
        }
        
    }
    
}