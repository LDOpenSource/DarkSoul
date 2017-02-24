

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightMutantInformations : GameFightFighterNamedInformations
    {
        public override short TypeId => 50;
        
        public sbyte powerLevel;
        
        public GameFightMutantInformations()
        {
        }
        
        public GameFightMutantInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions, string name, Types.PlayerStatus status, sbyte powerLevel)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions, name, status)
        {
            this.powerLevel = powerLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(powerLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            powerLevel = reader.ReadSByte();
        }
        
    }
    
}