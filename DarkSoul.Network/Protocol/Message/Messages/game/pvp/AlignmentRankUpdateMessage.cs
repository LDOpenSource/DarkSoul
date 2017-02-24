

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
    public class AlignmentRankUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6058;
        
        
        public sbyte alignmentRank;
        public bool verbose;
        
        public AlignmentRankUpdateMessage()
        {
        }
        
        public AlignmentRankUpdateMessage(sbyte alignmentRank, bool verbose)
        {
            this.alignmentRank = alignmentRank;
            this.verbose = verbose;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(alignmentRank);
            writer.WriteBoolean(verbose);
        }
        
        public override void Deserialize(IReader reader)
        {
            alignmentRank = reader.ReadSByte();
            verbose = reader.ReadBoolean();
        }
        
    }
    
}