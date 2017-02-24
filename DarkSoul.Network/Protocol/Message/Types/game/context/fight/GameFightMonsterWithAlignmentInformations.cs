

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
    {
        public override short TypeId => 203;
        
        public Types.ActorAlignmentInformations alignmentInfos;
        
        public GameFightMonsterWithAlignmentInformations()
        {
        }
        
        public GameFightMonsterWithAlignmentInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions, ushort creatureGenericId, sbyte creatureGrade, Types.ActorAlignmentInformations alignmentInfos)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions, creatureGenericId, creatureGrade)
        {
            this.alignmentInfos = alignmentInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            alignmentInfos.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            alignmentInfos = new Types.ActorAlignmentInformations();
            alignmentInfos.Deserialize(reader);
        }
        
    }
    
}