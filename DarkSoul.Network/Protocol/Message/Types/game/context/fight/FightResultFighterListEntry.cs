

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultFighterListEntry : FightResultListEntry
    {
        public override short TypeId => 189;
        
        public double id;
        public bool alive;
        
        public FightResultFighterListEntry()
        {
        }
        
        public FightResultFighterListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive)
         : base(outcome, wave, rewards)
        {
            this.id = id;
            this.alive = alive;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(id);
            writer.WriteBoolean(alive);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            id = reader.ReadDouble();
            alive = reader.ReadBoolean();
        }
        
    }
    
}