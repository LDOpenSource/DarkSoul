

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
    {
        public override short TypeId => 159;
        
        public Types.HumanInformations humanoidInfo;
        public int accountId;
        
        public GameRolePlayHumanoidInformations()
        {
        }
        
        public GameRolePlayHumanoidInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, Types.HumanInformations humanoidInfo, int accountId)
         : base(contextualId, look, disposition, name)
        {
            this.humanoidInfo = humanoidInfo;
            this.accountId = accountId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(humanoidInfo.TypeId);
            humanoidInfo.Serialize(writer);
            writer.WriteInt(accountId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            humanoidInfo = ProtocolTypeManager.GetInstance<Types.HumanInformations>(reader.ReadUShort());
            humanoidInfo.Deserialize(reader);
            accountId = reader.ReadInt();
        }
        
    }
    
}