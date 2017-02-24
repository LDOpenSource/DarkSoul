

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterNamedLightInformations : GameFightFighterLightInformations
    {
        public override short TypeId => 456;
        
        public string name;
        
        public GameFightFighterNamedLightInformations()
        {
        }
        
        public GameFightFighterNamedLightInformations(bool sex, bool alive, double id, sbyte wave, ushort level, sbyte breed, string name)
         : base(sex, alive, id, wave, level, breed)
        {
            this.name = name;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
        }
        
    }
    
}