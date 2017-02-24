

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
    {
        public override short TypeId => 180;
        
        public string ownerName;
        public byte level;
        
        public GameRolePlayMountInformations()
        {
        }
        
        public GameRolePlayMountInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, string ownerName, byte level)
         : base(contextualId, look, disposition, name)
        {
            this.ownerName = ownerName;
            this.level = level;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(ownerName);
            writer.WriteByte(level);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            ownerName = reader.ReadUTF();
            level = reader.ReadByte();
        }
        
    }
    
}