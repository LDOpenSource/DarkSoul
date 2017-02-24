

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
    {
        public override short TypeId => 129;
        
        public sbyte sellType;
        public IEnumerable<Types.HumanOption> options;
        
        public GameRolePlayMerchantInformations()
        {
        }
        
        public GameRolePlayMerchantInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, sbyte sellType, IEnumerable<Types.HumanOption> options)
         : base(contextualId, look, disposition, name)
        {
            this.sellType = sellType;
            this.options = options;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(sellType);
            writer.WriteShort((short)options.Count());
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            sellType = reader.ReadSByte();
            var limit = reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 (options as Types.HumanOption[])[i] = ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadUShort());
                 (options as Types.HumanOption[])[i].Deserialize(reader);
            }
        }
        
    }
    
}