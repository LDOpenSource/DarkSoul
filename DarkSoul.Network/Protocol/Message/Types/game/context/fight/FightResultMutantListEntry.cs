

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultMutantListEntry : FightResultFighterListEntry
    {
        public override short TypeId => 216;
        
        public ushort level;
        
        public FightResultMutantListEntry()
        {
        }
        
        public FightResultMutantListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, ushort level)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)level);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadVarUhShort();
        }
        
    }
    
}