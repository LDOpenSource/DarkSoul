

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightResumeMessage : GameFightSpectateMessage
    {
        public override ushort Id => 6067;
        
        
        public IEnumerable<Types.GameFightSpellCooldown> spellCooldowns;
        public sbyte summonCount;
        public sbyte bombCount;
        
        public GameFightResumeMessage()
        {
        }
        
        public GameFightResumeMessage(IEnumerable<Types.FightDispellableEffectExtendedInformations> effects, IEnumerable<Types.GameActionMark> marks, ushort gameTurn, int fightStart, IEnumerable<Types.Idol> idols, IEnumerable<Types.GameFightSpellCooldown> spellCooldowns, sbyte summonCount, sbyte bombCount)
         : base(effects, marks, gameTurn, fightStart, idols)
        {
            this.spellCooldowns = spellCooldowns;
            this.summonCount = summonCount;
            this.bombCount = bombCount;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)spellCooldowns.Count());
            foreach (var entry in spellCooldowns)
            {
                 entry.Serialize(writer);
            }
            writer.WriteSByte(summonCount);
            writer.WriteSByte(bombCount);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            spellCooldowns = new Types.GameFightSpellCooldown[limit];
            for (int i = 0; i < limit; i++)
            {
                 (spellCooldowns as Types.GameFightSpellCooldown[])[i] = new Types.GameFightSpellCooldown();
                 (spellCooldowns as Types.GameFightSpellCooldown[])[i].Deserialize(reader);
            }
            summonCount = reader.ReadSByte();
            bombCount = reader.ReadSByte();
        }
        
    }
    
}