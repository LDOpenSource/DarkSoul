

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayGroupMonsterInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 160;
        
        public bool keyRingBonus;
        public bool hasHardcoreDrop;
        public bool hasAVARewardToken;
        public Types.GroupMonsterStaticInformations staticInfos;
        public double creationTime;
        public int ageBonusRate;
        public sbyte lootShare;
        public sbyte alignmentSide;
        
        public GameRolePlayGroupMonsterInformations()
        {
        }
        
        public GameRolePlayGroupMonsterInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, bool keyRingBonus, bool hasHardcoreDrop, bool hasAVARewardToken, Types.GroupMonsterStaticInformations staticInfos, double creationTime, int ageBonusRate, sbyte lootShare, sbyte alignmentSide)
         : base(contextualId, look, disposition)
        {
            this.keyRingBonus = keyRingBonus;
            this.hasHardcoreDrop = hasHardcoreDrop;
            this.hasAVARewardToken = hasAVARewardToken;
            this.staticInfos = staticInfos;
            this.creationTime = creationTime;
            this.ageBonusRate = ageBonusRate;
            this.lootShare = lootShare;
            this.alignmentSide = alignmentSide;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, keyRingBonus);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, hasHardcoreDrop);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, hasAVARewardToken);
            writer.WriteByte(flag1);
            writer.WriteShort(staticInfos.TypeId);
            staticInfos.Serialize(writer);
            writer.WriteDouble(creationTime);
            writer.WriteInt(ageBonusRate);
            writer.WriteSByte(lootShare);
            writer.WriteSByte(alignmentSide);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            keyRingBonus = BooleanByteWrapper.GetFlag(flag1, 0);
            hasHardcoreDrop = BooleanByteWrapper.GetFlag(flag1, 1);
            hasAVARewardToken = BooleanByteWrapper.GetFlag(flag1, 2);
            staticInfos = ProtocolTypeManager.GetInstance<Types.GroupMonsterStaticInformations>(reader.ReadUShort());
            staticInfos.Deserialize(reader);
            creationTime = reader.ReadDouble();
            ageBonusRate = reader.ReadInt();
            lootShare = reader.ReadSByte();
            alignmentSide = reader.ReadSByte();
        }
        
    }
    
}