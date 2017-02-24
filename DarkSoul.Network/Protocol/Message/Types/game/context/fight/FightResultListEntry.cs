

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultListEntry
    {
        public virtual short TypeId => 16;
        
        public ushort outcome;
        public sbyte wave;
        public Types.FightLoot rewards;
        
        public FightResultListEntry()
        {
        }
        
        public FightResultListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards)
        {
            this.outcome = outcome;
            this.wave = wave;
            this.rewards = rewards;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)outcome);
            writer.WriteSByte(wave);
            rewards.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            outcome = reader.ReadVarUhShort();
            wave = reader.ReadSByte();
            rewards = new Types.FightLoot();
            rewards.Deserialize(reader);
        }
        
    }
    
}