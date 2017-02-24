

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayNamedActorInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 154;
        
        public string name;
        
        public GameRolePlayNamedActorInformations()
        {
        }
        
        public GameRolePlayNamedActorInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name)
         : base(contextualId, look, disposition)
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