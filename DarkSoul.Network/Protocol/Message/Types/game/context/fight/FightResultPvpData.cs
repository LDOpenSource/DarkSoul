

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightResultPvpData : FightResultAdditionalData
    {
        public override short TypeId => 190;
        
        public byte grade;
        public ushort minHonorForGrade;
        public ushort maxHonorForGrade;
        public ushort honor;
        public short honorDelta;
        
        public FightResultPvpData()
        {
        }
        
        public FightResultPvpData(byte grade, ushort minHonorForGrade, ushort maxHonorForGrade, ushort honor, short honorDelta)
        {
            this.grade = grade;
            this.minHonorForGrade = minHonorForGrade;
            this.maxHonorForGrade = maxHonorForGrade;
            this.honor = honor;
            this.honorDelta = honorDelta;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(grade);
            writer.WriteVarShort((int)minHonorForGrade);
            writer.WriteVarShort((int)maxHonorForGrade);
            writer.WriteVarShort((int)honor);
            writer.WriteVarShort((int)honorDelta);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            grade = reader.ReadByte();
            minHonorForGrade = reader.ReadVarUhShort();
            maxHonorForGrade = reader.ReadVarUhShort();
            honor = reader.ReadVarUhShort();
            honorDelta = reader.ReadVarShort();
        }
        
    }
    
}