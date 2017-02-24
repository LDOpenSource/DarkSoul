

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
    {
        public override short TypeId => 474;
        
        public sbyte deathState;
        public ushort deathCount;
        public byte deathMaxLevel;
        
        public CharacterHardcoreOrEpicInformations()
        {
        }
        
        public CharacterHardcoreOrEpicInformations(double id, string name, byte level, Types.EntityLook entityLook, sbyte breed, bool sex, sbyte deathState, ushort deathCount, byte deathMaxLevel)
         : base(id, name, level, entityLook, breed, sex)
        {
            this.deathState = deathState;
            this.deathCount = deathCount;
            this.deathMaxLevel = deathMaxLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(deathState);
            writer.WriteVarShort((int)deathCount);
            writer.WriteByte(deathMaxLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            deathState = reader.ReadSByte();
            deathCount = reader.ReadVarUhShort();
            deathMaxLevel = reader.ReadByte();
        }
        
    }
    
}