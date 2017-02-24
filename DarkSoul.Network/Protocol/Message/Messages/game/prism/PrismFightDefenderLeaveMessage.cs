

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
    public class PrismFightDefenderLeaveMessage : NetworkMessage
    {
        public override ushort Id => 5892;
        
        
        public ushort subAreaId;
        public ushort fightId;
        public double fighterToRemoveId;
        
        public PrismFightDefenderLeaveMessage()
        {
        }
        
        public PrismFightDefenderLeaveMessage(ushort subAreaId, ushort fightId, double fighterToRemoveId)
        {
            this.subAreaId = subAreaId;
            this.fightId = fightId;
            this.fighterToRemoveId = fighterToRemoveId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteVarShort((int)fightId);
            writer.WriteVarLong(fighterToRemoveId);
        }
        
        public override void Deserialize(IReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            fightId = reader.ReadVarUhShort();
            fighterToRemoveId = reader.ReadVarUhLong();
        }
        
    }
    
}