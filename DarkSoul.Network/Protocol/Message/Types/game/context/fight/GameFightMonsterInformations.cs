

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightMonsterInformations : GameFightAIInformations
    {
        public override short TypeId => 29;
        
        public ushort creatureGenericId;
        public sbyte creatureGrade;
        
        public GameFightMonsterInformations()
        {
        }
        
        public GameFightMonsterInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions, ushort creatureGenericId, sbyte creatureGrade)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
        {
            this.creatureGenericId = creatureGenericId;
            this.creatureGrade = creatureGrade;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)creatureGenericId);
            writer.WriteSByte(creatureGrade);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUhShort();
            creatureGrade = reader.ReadSByte();
        }
        
    }
    
}