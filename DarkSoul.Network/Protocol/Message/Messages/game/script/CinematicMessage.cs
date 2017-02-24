

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CinematicMessage : NetworkMessage
    {
        public override ushort Id => 6053;
        
        
        public ushort cinematicId;
        
        public CinematicMessage()
        {
        }
        
        public CinematicMessage(ushort cinematicId)
        {
            this.cinematicId = cinematicId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cinematicId);
        }
        
        public override void Deserialize(IReader reader)
        {
            cinematicId = reader.ReadVarUhShort();
        }
        
    }
    
}