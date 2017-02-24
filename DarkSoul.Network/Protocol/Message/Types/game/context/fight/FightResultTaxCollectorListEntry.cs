

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultTaxCollectorListEntry : FightResultFighterListEntry
    {
        public override short TypeId => 84;
        
        public byte level;
        public Types.BasicGuildInformations guildInfo;
        public int experienceForGuild;
        
        public FightResultTaxCollectorListEntry()
        {
        }
        
        public FightResultTaxCollectorListEntry(ushort outcome, sbyte wave, Types.FightLoot rewards, double id, bool alive, byte level, Types.BasicGuildInformations guildInfo, int experienceForGuild)
         : base(outcome, wave, rewards, id, alive)
        {
            this.level = level;
            this.guildInfo = guildInfo;
            this.experienceForGuild = experienceForGuild;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(level);
            guildInfo.Serialize(writer);
            writer.WriteInt(experienceForGuild);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadByte();
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
            experienceForGuild = reader.ReadInt();
        }
        
    }
    
}