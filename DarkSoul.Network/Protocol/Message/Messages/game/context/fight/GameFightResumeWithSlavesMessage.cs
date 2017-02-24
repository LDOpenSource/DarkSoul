

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
    public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
    {
        public override ushort Id => 6215;
        
        
        public IEnumerable<Types.GameFightResumeSlaveInfo> slavesInfo;
        
        public GameFightResumeWithSlavesMessage()
        {
        }
        
        public GameFightResumeWithSlavesMessage(IEnumerable<Types.FightDispellableEffectExtendedInformations> effects, IEnumerable<Types.GameActionMark> marks, ushort gameTurn, int fightStart, IEnumerable<Types.Idol> idols, IEnumerable<Types.GameFightSpellCooldown> spellCooldowns, sbyte summonCount, sbyte bombCount, IEnumerable<Types.GameFightResumeSlaveInfo> slavesInfo)
         : base(effects, marks, gameTurn, fightStart, idols, spellCooldowns, summonCount, bombCount)
        {
            this.slavesInfo = slavesInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)slavesInfo.Count());
            foreach (var entry in slavesInfo)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            slavesInfo = new Types.GameFightResumeSlaveInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 (slavesInfo as Types.GameFightResumeSlaveInfo[])[i] = new Types.GameFightResumeSlaveInfo();
                 (slavesInfo as Types.GameFightResumeSlaveInfo[])[i].Deserialize(reader);
            }
        }
        
    }
    
}