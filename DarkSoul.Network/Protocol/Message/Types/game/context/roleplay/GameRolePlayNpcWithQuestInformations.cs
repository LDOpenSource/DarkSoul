

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
    {
        public override short TypeId => 383;
        
        public Types.GameRolePlayNpcQuestFlag questFlag;
        
        public GameRolePlayNpcWithQuestInformations()
        {
        }
        
        public GameRolePlayNpcWithQuestInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId, bool sex, ushort specialArtworkId, Types.GameRolePlayNpcQuestFlag questFlag)
         : base(contextualId, look, disposition, npcId, sex, specialArtworkId)
        {
            this.questFlag = questFlag;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            questFlag.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            questFlag = new Types.GameRolePlayNpcQuestFlag();
            questFlag.Deserialize(reader);
        }
        
    }
    
}