

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TrustCertificate
    {
        public virtual short TypeId => 377;
        
        public int id;
        public string hash;
        
        public TrustCertificate()
        {
        }
        
        public TrustCertificate(int id, string hash)
        {
            this.id = id;
            this.hash = hash;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(id);
            writer.WriteUTF(hash);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            id = reader.ReadInt();
            hash = reader.ReadUTF();
        }
        
    }
    
}