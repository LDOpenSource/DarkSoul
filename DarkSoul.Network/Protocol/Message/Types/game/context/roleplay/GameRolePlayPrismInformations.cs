

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayPrismInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 161;
        
        public Types.PrismInformation prism;
        
        public GameRolePlayPrismInformations()
        {
        }
        
        public GameRolePlayPrismInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.PrismInformation prism)
         : base(contextualId, look, disposition)
        {
            this.prism = prism;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(prism.TypeId);
            prism.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            prism = ProtocolTypeManager.GetInstance<Types.PrismInformation>(reader.ReadUShort());
            prism.Deserialize(reader);
        }
        
    }
    
}