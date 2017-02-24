

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class IgnoredInformations : AbstractContactInformations
    {
        public override short TypeId => 106;
        
        
        public IgnoredInformations()
        {
        }
        
        public IgnoredInformations(int accountId, string accountName)
         : base(accountId, accountName)
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