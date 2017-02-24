

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
    public class JobMultiCraftAvailableSkillsMessage : JobAllowMultiCraftRequestMessage
    {
        public override ushort Id => 5747;
        
        
        public double playerId;
        public IEnumerable<ushort> skills;
        
        public JobMultiCraftAvailableSkillsMessage()
        {
        }
        
        public JobMultiCraftAvailableSkillsMessage(bool enabled, double playerId, IEnumerable<ushort> skills)
         : base(enabled)
        {
            this.playerId = playerId;
            this.skills = skills;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteShort((short)skills.Count());
            foreach (var entry in skills)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            var limit = reader.ReadUShort();
            skills = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (skills as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}