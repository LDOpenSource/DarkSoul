

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class VersionExtended : Version
    {
        public override short TypeId => 393;
        
        public sbyte install;
        public sbyte technology;
        
        public VersionExtended()
        {
        }
        
        public VersionExtended(sbyte major, sbyte minor, sbyte release, int revision, sbyte patch, sbyte buildType, sbyte install, sbyte technology)
         : base(major, minor, release, revision, patch, buildType)
        {
            this.install = install;
            this.technology = technology;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(install);
            writer.WriteSByte(technology);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            install = reader.ReadSByte();
            technology = reader.ReadSByte();
        }
        
    }
    
}