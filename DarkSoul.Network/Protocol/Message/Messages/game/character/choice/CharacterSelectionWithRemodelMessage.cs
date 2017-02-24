

// Generated on 02/23/2017 16:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
    {
        public override ushort Id => 6549;
        
        
        public Types.RemodelingInformation remodel;
        
        public CharacterSelectionWithRemodelMessage()
        {
        }
        
        public CharacterSelectionWithRemodelMessage(double id, Types.RemodelingInformation remodel)
         : base(id)
        {
            this.remodel = remodel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            remodel.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            remodel = new Types.RemodelingInformation();
            remodel.Deserialize(reader);
        }
        
    }
    
}