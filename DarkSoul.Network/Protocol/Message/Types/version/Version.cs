

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class Version
    {
        public virtual short TypeId => 11;
        
        public sbyte major;
        public sbyte minor;
        public sbyte release;
        public int revision;
        public sbyte patch;
        public sbyte buildType;
        
        public Version()
        {
        }
        
        public Version(sbyte major, sbyte minor, sbyte release, int revision, sbyte patch, sbyte buildType)
        {
            this.major = major;
            this.minor = minor;
            this.release = release;
            this.revision = revision;
            this.patch = patch;
            this.buildType = buildType;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(major);
            writer.WriteSByte(minor);
            writer.WriteSByte(release);
            writer.WriteInt(revision);
            writer.WriteSByte(patch);
            writer.WriteSByte(buildType);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            major = reader.ReadSByte();
            minor = reader.ReadSByte();
            release = reader.ReadSByte();
            revision = reader.ReadInt();
            patch = reader.ReadSByte();
            buildType = reader.ReadSByte();
        }
        
    }
    
}