

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
    public class GameFightSpectateMessage : NetworkMessage
    {
        public override ushort Id => 6069;
        
        
        public IEnumerable<Types.FightDispellableEffectExtendedInformations> effects;
        public IEnumerable<Types.GameActionMark> marks;
        public ushort gameTurn;
        public int fightStart;
        public IEnumerable<Types.Idol> idols;
        
        public GameFightSpectateMessage()
        {
        }
        
        public GameFightSpectateMessage(IEnumerable<Types.FightDispellableEffectExtendedInformations> effects, IEnumerable<Types.GameActionMark> marks, ushort gameTurn, int fightStart, IEnumerable<Types.Idol> idols)
        {
            this.effects = effects;
            this.marks = marks;
            this.gameTurn = gameTurn;
            this.fightStart = fightStart;
            this.idols = idols;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)effects.Count());
            foreach (var entry in effects)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)marks.Count());
            foreach (var entry in marks)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarShort((int)gameTurn);
            writer.WriteInt(fightStart);
            writer.WriteShort((short)idols.Count());
            foreach (var entry in idols)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            effects = new Types.FightDispellableEffectExtendedInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (effects as Types.FightDispellableEffectExtendedInformations[])[i] = new Types.FightDispellableEffectExtendedInformations();
                 (effects as Types.FightDispellableEffectExtendedInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            marks = new Types.GameActionMark[limit];
            for (int i = 0; i < limit; i++)
            {
                 (marks as Types.GameActionMark[])[i] = new Types.GameActionMark();
                 (marks as Types.GameActionMark[])[i].Deserialize(reader);
            }
            gameTurn = reader.ReadVarUhShort();
            fightStart = reader.ReadInt();
            limit = reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idols as Types.Idol[])[i] = new Types.Idol();
                 (idols as Types.Idol[])[i].Deserialize(reader);
            }
        }
        
    }
    
}