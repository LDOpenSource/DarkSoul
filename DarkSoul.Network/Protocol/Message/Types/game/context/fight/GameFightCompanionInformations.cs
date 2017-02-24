

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightCompanionInformations : GameFightFighterInformations
    {
        public override short TypeId => 450;
        
        public sbyte companionGenericId;
        public byte level;
        public double masterId;
        
        public GameFightCompanionInformations()
        {
        }
        
        public GameFightCompanionInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions, sbyte companionGenericId, byte level, double masterId)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
        {
            this.companionGenericId = companionGenericId;
            this.level = level;
            this.masterId = masterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(companionGenericId);
            writer.WriteByte(level);
            writer.WriteDouble(masterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            companionGenericId = reader.ReadSByte();
            level = reader.ReadByte();
            masterId = reader.ReadDouble();
        }
        
    }
    
}