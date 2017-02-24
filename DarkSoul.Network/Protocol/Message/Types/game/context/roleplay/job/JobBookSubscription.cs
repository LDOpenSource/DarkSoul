

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobBookSubscription
    {
        public virtual short TypeId => 500;
        
        public sbyte jobId;
        public bool subscribed;
        
        public JobBookSubscription()
        {
        }
        
        public JobBookSubscription(sbyte jobId, bool subscribed)
        {
            this.jobId = jobId;
            this.subscribed = subscribed;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
            writer.WriteBoolean(subscribed);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
            subscribed = reader.ReadBoolean();
        }
        
    }
    
}