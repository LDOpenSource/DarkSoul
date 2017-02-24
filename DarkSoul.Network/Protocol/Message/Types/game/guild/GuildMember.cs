

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GuildMember : CharacterMinimalInformations
    {
        public override short TypeId => 88;
        
        public bool sex;
        public bool havenBagShared;
        public sbyte breed;
        public ushort rank;
        public double givenExperience;
        public sbyte experienceGivenPercent;
        public uint rights;
        public sbyte connected;
        public sbyte alignmentSide;
        public ushort hoursSinceLastConnection;
        public ushort moodSmileyId;
        public int accountId;
        public int achievementPoints;
        public Types.PlayerStatus status;
        
        public GuildMember()
        {
        }
        
        public GuildMember(double id, string name, byte level, bool sex, bool havenBagShared, sbyte breed, ushort rank, double givenExperience, sbyte experienceGivenPercent, uint rights, sbyte connected, sbyte alignmentSide, ushort hoursSinceLastConnection, ushort moodSmileyId, int accountId, int achievementPoints, Types.PlayerStatus status)
         : base(id, name, level)
        {
            this.sex = sex;
            this.havenBagShared = havenBagShared;
            this.breed = breed;
            this.rank = rank;
            this.givenExperience = givenExperience;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
            this.connected = connected;
            this.alignmentSide = alignmentSide;
            this.hoursSinceLastConnection = hoursSinceLastConnection;
            this.moodSmileyId = moodSmileyId;
            this.accountId = accountId;
            this.achievementPoints = achievementPoints;
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, sex);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, havenBagShared);
            writer.WriteByte(flag1);
            writer.WriteSByte(breed);
            writer.WriteVarShort((int)rank);
            writer.WriteVarLong(givenExperience);
            writer.WriteSByte(experienceGivenPercent);
            writer.WriteVarInt((int)rights);
            writer.WriteSByte(connected);
            writer.WriteSByte(alignmentSide);
            writer.WriteUShort(hoursSinceLastConnection);
            writer.WriteVarShort((int)moodSmileyId);
            writer.WriteInt(accountId);
            writer.WriteInt(achievementPoints);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            sex = BooleanByteWrapper.GetFlag(flag1, 0);
            havenBagShared = BooleanByteWrapper.GetFlag(flag1, 1);
            breed = reader.ReadSByte();
            rank = reader.ReadVarUhShort();
            givenExperience = reader.ReadVarUhLong();
            experienceGivenPercent = reader.ReadSByte();
            rights = reader.ReadVarUhInt();
            connected = reader.ReadSByte();
            alignmentSide = reader.ReadSByte();
            hoursSinceLastConnection = reader.ReadUShort();
            moodSmileyId = reader.ReadVarUhShort();
            accountId = reader.ReadInt();
            achievementPoints = reader.ReadInt();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
        }
        
    }
    
}