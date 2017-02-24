

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightCharacterInformations : GameFightFighterNamedInformations
    {
        public override short TypeId => 46;
        
        public byte level;
        public Types.ActorAlignmentInformations alignmentInfos;
        public sbyte breed;
        public bool sex;
        
        public GameFightCharacterInformations()
        {
        }
        
        public GameFightCharacterInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions, string name, Types.PlayerStatus status, byte level, Types.ActorAlignmentInformations alignmentInfos, sbyte breed, bool sex)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions, name, status)
        {
            this.level = level;
            this.alignmentInfos = alignmentInfos;
            this.breed = breed;
            this.sex = sex;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(level);
            alignmentInfos.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            level = reader.ReadByte();
            alignmentInfos = new Types.ActorAlignmentInformations();
            alignmentInfos.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
        }
        
    }
    
}