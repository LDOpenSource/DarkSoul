

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FriendSpouseInformations
    {
        public virtual short TypeId => 77;
        
        public int spouseAccountId;
        public double spouseId;
        public string spouseName;
        public byte spouseLevel;
        public sbyte breed;
        public sbyte sex;
        public Types.EntityLook spouseEntityLook;
        public Types.GuildInformations guildInfo;
        public sbyte alignmentSide;
        
        public FriendSpouseInformations()
        {
        }
        
        public FriendSpouseInformations(int spouseAccountId, double spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.GuildInformations guildInfo, sbyte alignmentSide)
        {
            this.spouseAccountId = spouseAccountId;
            this.spouseId = spouseId;
            this.spouseName = spouseName;
            this.spouseLevel = spouseLevel;
            this.breed = breed;
            this.sex = sex;
            this.spouseEntityLook = spouseEntityLook;
            this.guildInfo = guildInfo;
            this.alignmentSide = alignmentSide;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(spouseAccountId);
            writer.WriteVarLong(spouseId);
            writer.WriteUTF(spouseName);
            writer.WriteByte(spouseLevel);
            writer.WriteSByte(breed);
            writer.WriteSByte(sex);
            spouseEntityLook.Serialize(writer);
            guildInfo.Serialize(writer);
            writer.WriteSByte(alignmentSide);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            spouseAccountId = reader.ReadInt();
            spouseId = reader.ReadVarUhLong();
            spouseName = reader.ReadUTF();
            spouseLevel = reader.ReadByte();
            breed = reader.ReadSByte();
            sex = reader.ReadSByte();
            spouseEntityLook = new Types.EntityLook();
            spouseEntityLook.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            alignmentSide = reader.ReadSByte();
        }
        
    }
    
}