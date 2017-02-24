

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterInformations : GameContextActorInformations
    {
        public override short TypeId => 143;
        
        public sbyte teamId;
        public sbyte wave;
        public bool alive;
        public Types.GameFightMinimalStats stats;
        public IEnumerable<ushort> previousPositions;
        
        public GameFightFighterInformations()
        {
        }
        
        public GameFightFighterInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions)
         : base(contextualId, look, disposition)
        {
            this.teamId = teamId;
            this.wave = wave;
            this.alive = alive;
            this.stats = stats;
            this.previousPositions = previousPositions;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(teamId);
            writer.WriteSByte(wave);
            writer.WriteBoolean(alive);
            writer.WriteShort(stats.TypeId);
            stats.Serialize(writer);
            writer.WriteShort((short)previousPositions.Count());
            foreach (var entry in previousPositions)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            teamId = reader.ReadSByte();
            wave = reader.ReadSByte();
            alive = reader.ReadBoolean();
            stats = ProtocolTypeManager.GetInstance<Types.GameFightMinimalStats>(reader.ReadUShort());
            stats.Deserialize(reader);
            var limit = reader.ReadUShort();
            previousPositions = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (previousPositions as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}