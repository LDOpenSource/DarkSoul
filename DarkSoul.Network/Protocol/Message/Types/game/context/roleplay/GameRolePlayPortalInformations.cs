

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayPortalInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 467;
        
        public Types.PortalInformation portal;
        
        public GameRolePlayPortalInformations()
        {
        }
        
        public GameRolePlayPortalInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.PortalInformation portal)
         : base(contextualId, look, disposition)
        {
            this.portal = portal;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(portal.TypeId);
            portal.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            portal = ProtocolTypeManager.GetInstance<Types.PortalInformation>(reader.ReadUShort());
            portal.Deserialize(reader);
        }
        
    }
    
}