

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
    {
        public override short TypeId => 3;
        
        public ushort monsterId;
        public sbyte powerLevel;
        
        public GameRolePlayMutantInformations()
        {
        }
        
        public GameRolePlayMutantInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, string name, Types.HumanInformations humanoidInfo, int accountId, ushort monsterId, sbyte powerLevel)
         : base(contextualId, look, disposition, name, humanoidInfo, accountId)
        {
            this.monsterId = monsterId;
            this.powerLevel = powerLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)monsterId);
            writer.WriteSByte(powerLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            monsterId = reader.ReadVarUhShort();
            powerLevel = reader.ReadSByte();
        }
        
    }
    
}