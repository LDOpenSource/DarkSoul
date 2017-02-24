

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultPlayerListEntry : FightResultFighterListEntry
    {
        public override short TypeId => 24;
        
        public byte level;
        public IEnumerable<Types.FightResultAdditionalData> additional;
        
        public FightResultPlayerListEntry()
        {
        }
        
        public FightResultPlayerListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, byte level, IEnumerable<Types.FightResultAdditionalData> additional)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
            this.additional = additional;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(level);
            writer.WriteShort((short)additional.Count());
            foreach (var entry in additional)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadByte();
            var limit = reader.ReadUShort();
            additional = new Types.FightResultAdditionalData[limit];
            for (int i = 0; i < limit; i++)
            {
                 (additional as Types.FightResultAdditionalData[])[i] = ProtocolTypeManager.GetInstance<Types.FightResultAdditionalData>(reader.ReadUShort());
                 (additional as Types.FightResultAdditionalData[])[i].Deserialize(reader);
            }
        }
        
    }
    
}