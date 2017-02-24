

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PlayerStatus
    {
        public virtual short TypeId => 415;
        
        public sbyte statusId;
        
        public PlayerStatus()
        {
        }
        
        public PlayerStatus(sbyte statusId)
        {
            this.statusId = statusId;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(statusId);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            statusId = reader.ReadSByte();
        }
        
    }
    
}