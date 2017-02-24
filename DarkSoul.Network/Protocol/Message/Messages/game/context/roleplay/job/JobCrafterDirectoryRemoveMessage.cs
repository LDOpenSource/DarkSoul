

// Generated on 02/23/2017 16:53:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class JobCrafterDirectoryRemoveMessage : NetworkMessage
    {
        public override ushort Id => 5653;
        
        
        public sbyte jobId;
        public double playerId;
        
        public JobCrafterDirectoryRemoveMessage()
        {
        }
        
        public JobCrafterDirectoryRemoveMessage(sbyte jobId, double playerId)
        {
            this.jobId = jobId;
            this.playerId = playerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
            writer.WriteVarLong(playerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
            playerId = reader.ReadVarUhLong();
        }
        
    }
    
}