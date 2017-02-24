

// Generated on 02/23/2017 16:54:01
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PrismFightJoinLeaveRequestMessage : NetworkMessage
    {
        public override ushort Id => 5843;
        
        
        public ushort subAreaId;
        public bool join;
        
        public PrismFightJoinLeaveRequestMessage()
        {
        }
        
        public PrismFightJoinLeaveRequestMessage(ushort subAreaId, bool join)
        {
            this.subAreaId = subAreaId;
            this.join = join;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteBoolean(join);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            join = reader.ReadBoolean();
        }
        
    }
    
}