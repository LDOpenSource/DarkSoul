

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class JobExperience
    {
        public virtual short TypeId => 98;
        
        public sbyte jobId;
        public byte jobLevel;
        public double jobXP;
        public double jobXpLevelFloor;
        public double jobXpNextLevelFloor;
        
        public JobExperience()
        {
        }
        
        public JobExperience(sbyte jobId, byte jobLevel, double jobXP, double jobXpLevelFloor, double jobXpNextLevelFloor)
        {
            this.jobId = jobId;
            this.jobLevel = jobLevel;
            this.jobXP = jobXP;
            this.jobXpLevelFloor = jobXpLevelFloor;
            this.jobXpNextLevelFloor = jobXpNextLevelFloor;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(jobId);
            writer.WriteByte(jobLevel);
            writer.WriteVarLong(jobXP);
            writer.WriteVarLong(jobXpLevelFloor);
            writer.WriteVarLong(jobXpNextLevelFloor);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            jobId = reader.ReadSByte();
            jobLevel = reader.ReadByte();
            jobXP = reader.ReadVarUhLong();
            jobXpLevelFloor = reader.ReadVarUhLong();
            jobXpNextLevelFloor = reader.ReadVarUhLong();
        }
        
    }
    
}