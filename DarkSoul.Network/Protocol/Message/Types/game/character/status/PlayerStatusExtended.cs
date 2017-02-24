

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PlayerStatusExtended : PlayerStatus
    {
        public override short TypeId => 414;
        
        public string message;
        
        public PlayerStatusExtended()
        {
        }
        
        public PlayerStatusExtended(sbyte statusId, string message)
         : base(statusId)
        {
            this.message = message;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(message);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            message = reader.ReadUTF();
        }
        
    }
    
}