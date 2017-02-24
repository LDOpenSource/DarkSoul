

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class AbstractContactInformations
    {
        public virtual short TypeId => 380;
        
        public int accountId;
        public string accountName;
        
        public AbstractContactInformations()
        {
        }
        
        public AbstractContactInformations(int accountId, string accountName)
        {
            this.accountId = accountId;
            this.accountName = accountName;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(accountId);
            writer.WriteUTF(accountName);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            accountId = reader.ReadInt();
            accountName = reader.ReadUTF();
        }
        
    }
    
}