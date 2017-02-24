

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 148;
        
        public Types.TaxCollectorStaticInformations identification;
        public byte guildLevel;
        public int taxCollectorAttack;
        
        public GameRolePlayTaxCollectorInformations()
        {
        }
        
        public GameRolePlayTaxCollectorInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, Types.TaxCollectorStaticInformations identification, byte guildLevel, int taxCollectorAttack)
         : base(contextualId, look, disposition)
        {
            this.identification = identification;
            this.guildLevel = guildLevel;
            this.taxCollectorAttack = taxCollectorAttack;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(identification.TypeId);
            identification.Serialize(writer);
            writer.WriteByte(guildLevel);
            writer.WriteInt(taxCollectorAttack);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            identification = ProtocolTypeManager.GetInstance<Types.TaxCollectorStaticInformations>(reader.ReadUShort());
            identification.Deserialize(reader);
            guildLevel = reader.ReadByte();
            taxCollectorAttack = reader.ReadInt();
        }
        
    }
    
}