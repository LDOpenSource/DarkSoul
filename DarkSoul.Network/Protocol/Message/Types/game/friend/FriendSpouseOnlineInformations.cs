

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FriendSpouseOnlineInformations : FriendSpouseInformations
    {
        public override short TypeId => 93;
        
        public bool inFight;
        public bool followSpouse;
        public int mapId;
        public ushort subAreaId;
        
        public FriendSpouseOnlineInformations()
        {
        }
        
        public FriendSpouseOnlineInformations(int spouseAccountId, double spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.GuildInformations guildInfo, sbyte alignmentSide, bool inFight, bool followSpouse, int mapId, ushort subAreaId)
         : base(spouseAccountId, spouseId, spouseName, spouseLevel, breed, sex, spouseEntityLook, guildInfo, alignmentSide)
        {
            this.inFight = inFight;
            this.followSpouse = followSpouse;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, inFight);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, followSpouse);
            writer.WriteByte(flag1);
            writer.WriteInt(mapId);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            byte flag1 = reader.ReadByte();
            inFight = BooleanByteWrapper.GetFlag(flag1, 0);
            followSpouse = BooleanByteWrapper.GetFlag(flag1, 1);
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}