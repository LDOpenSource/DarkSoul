

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterNamedInformations : GameFightFighterInformations
    {
        public override short TypeId => 158;
        
        public string name;
        public Types.PlayerStatus status;
        
        public GameFightFighterNamedInformations()
        {
        }
        
        public GameFightFighterNamedInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, IEnumerable<ushort> previousPositions, string name, Types.PlayerStatus status)
         : base(contextualId, look, disposition, teamId, wave, alive, stats, previousPositions)
        {
            this.name = name;
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            status.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            status = new Types.PlayerStatus();
            status.Deserialize(reader);
        }
        
    }
    
}