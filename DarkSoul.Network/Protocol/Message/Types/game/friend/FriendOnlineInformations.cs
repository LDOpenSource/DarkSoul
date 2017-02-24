

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FriendOnlineInformations : FriendInformations
    {
        public override short TypeId => 92;
        
        public bool sex;
        public bool havenBagShared;
        public double playerId;
        public string playerName;
        public byte level;
        public sbyte alignmentSide;
        public sbyte breed;
        public Types.GuildInformations guildInfo;
        public ushort moodSmileyId;
        public Types.PlayerStatus status;
        
        public FriendOnlineInformations()
        {
        }
        
        public FriendOnlineInformations(int accountId, string accountName, sbyte playerState, ushort lastConnection, int achievementPoints, bool sex, bool havenBagShared, double playerId, string playerName, byte level, sbyte alignmentSide, sbyte breed, Types.GuildInformations guildInfo, ushort moodSmileyId, Types.PlayerStatus status)
         : base(accountId, accountName, playerState, lastConnection, achievementPoints)
        {
            this.sex = sex;
            this.havenBagShared = havenBagShared;
            this.playerId = playerId;
            this.playerName = playerName;
            this.level = level;
            this.alignmentSide = alignmentSide;
            this.breed = breed;
            this.guildInfo = guildInfo;
            this.moodSmileyId = moodSmileyId;
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, sex);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, havenBagShared);
            writer.WriteByte(flag1);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteByte(level);
            writer.WriteSByte(alignmentSide);
            writer.WriteSByte(breed);
            guildInfo.Serialize(writer);
            writer.WriteVarShort((int)moodSmileyId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            sex = BooleanByteWrapper.GetFlag(flag1, 0);
            havenBagShared = BooleanByteWrapper.GetFlag(flag1, 1);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            level = reader.ReadByte();
            alignmentSide = reader.ReadSByte();
            breed = reader.ReadSByte();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
            moodSmileyId = reader.ReadVarUhShort();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
        }
        
    }
    
}