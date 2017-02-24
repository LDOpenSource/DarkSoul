

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ActorExtendedAlignmentInformations : ActorAlignmentInformations
    {
        public override short TypeId => 202;
        
        public ushort honor;
        public ushort honorGradeFloor;
        public ushort honorNextGradeFloor;
        public sbyte aggressable;
        
        public ActorExtendedAlignmentInformations()
        {
        }
        
        public ActorExtendedAlignmentInformations(sbyte alignmentSide, sbyte alignmentValue, sbyte alignmentGrade, double characterPower, ushort honor, ushort honorGradeFloor, ushort honorNextGradeFloor, sbyte aggressable)
         : base(alignmentSide, alignmentValue, alignmentGrade, characterPower)
        {
            this.honor = honor;
            this.honorGradeFloor = honorGradeFloor;
            this.honorNextGradeFloor = honorNextGradeFloor;
            this.aggressable = aggressable;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)honor);
            writer.WriteVarShort((int)honorGradeFloor);
            writer.WriteVarShort((int)honorNextGradeFloor);
            writer.WriteSByte(aggressable);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            honor = reader.ReadVarUhShort();
            honorGradeFloor = reader.ReadVarUhShort();
            honorNextGradeFloor = reader.ReadVarUhShort();
            aggressable = reader.ReadSByte();
        }
        
    }
    
}