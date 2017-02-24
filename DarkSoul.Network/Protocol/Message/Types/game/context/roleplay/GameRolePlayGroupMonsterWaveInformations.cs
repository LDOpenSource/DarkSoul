

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayGroupMonsterWaveInformations : GameRolePlayGroupMonsterInformations
    {
        public override short TypeId => 464;
        
        public sbyte nbWaves;
        public IEnumerable<Types.GroupMonsterStaticInformations> alternatives;
        
        public GameRolePlayGroupMonsterWaveInformations()
        {
        }
        
        public GameRolePlayGroupMonsterWaveInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, Types.GroupMonsterStaticInformations staticInfos, double creationTime, int ageBonusRate, sbyte lootShare, sbyte alignmentSide, sbyte nbWaves, IEnumerable<Types.GroupMonsterStaticInformations> alternatives)
         : base(contextualId, look, disposition, keyRingBonus, hasHardcoreDrop, hasAVARewardToken, staticInfos, creationTime, ageBonusRate, lootShare, alignmentSide)
        {
            this.nbWaves = nbWaves;
            this.alternatives = alternatives;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(nbWaves);
            writer.WriteShort((short)alternatives.Count());
            foreach (var entry in alternatives)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            nbWaves = reader.ReadSByte();
            var limit = reader.ReadUShort();
            alternatives = new Types.GroupMonsterStaticInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alternatives as Types.GroupMonsterStaticInformations[])[i] = ProtocolTypeManager.GetInstance<Types.GroupMonsterStaticInformations>(reader.ReadUShort());
                 (alternatives as Types.GroupMonsterStaticInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}