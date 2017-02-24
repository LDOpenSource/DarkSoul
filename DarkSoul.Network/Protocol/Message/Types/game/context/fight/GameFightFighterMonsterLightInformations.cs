

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterMonsterLightInformations : GameFightFighterLightInformations
    {
        public override short TypeId => 455;
        
        public ushort creatureGenericId;
        
        public GameFightFighterMonsterLightInformations()
        {
        }
        
        public GameFightFighterMonsterLightInformations(bool sex, bool alive, double id, sbyte wave, ushort level, sbyte breed, ushort creatureGenericId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.creatureGenericId = creatureGenericId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)creatureGenericId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            creatureGenericId = reader.ReadVarUhShort();
        }
        
    }
    
}