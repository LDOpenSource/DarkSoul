

// Generated on 02/23/2017 16:53:24
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class BasicWhoIsMessage : NetworkMessage
    {
        public override ushort Id => 180;
        
        
        public bool self;
        public bool verbose;
        public sbyte position;
        public string accountNickname;
        public int accountId;
        public string playerName;
        public double playerId;
        public short areaId;
        public short serverId;
        public short originServerId;
        public IEnumerable<Types.AbstractSocialGroupInfos> socialGroups;
        public sbyte playerState;
        
        public BasicWhoIsMessage()
        {
        }
        
        public BasicWhoIsMessage(bool self, bool verbose, sbyte position, string accountNickname, int accountId, string playerName, double playerId, short areaId, short serverId, short originServerId, IEnumerable<Types.AbstractSocialGroupInfos> socialGroups, sbyte playerState)
        {
            this.self = self;
            this.verbose = verbose;
            this.position = position;
            this.accountNickname = accountNickname;
            this.accountId = accountId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.areaId = areaId;
            this.serverId = serverId;
            this.originServerId = originServerId;
            this.socialGroups = socialGroups;
            this.playerState = playerState;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, self);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, verbose);
            writer.WriteByte(flag1);
            writer.WriteSByte(position);
            writer.WriteUTF(accountNickname);
            writer.WriteInt(accountId);
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            writer.WriteShort(areaId);
            writer.WriteShort(serverId);
            writer.WriteShort(originServerId);
            writer.WriteShort((short)socialGroups.Count());
            foreach (var entry in socialGroups)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteSByte(playerState);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            self = BooleanByteWrapper.GetFlag(flag1, 0);
            verbose = BooleanByteWrapper.GetFlag(flag1, 1);
            position = reader.ReadSByte();
            accountNickname = reader.ReadUTF();
            accountId = reader.ReadInt();
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            areaId = reader.ReadShort();
            serverId = reader.ReadShort();
            originServerId = reader.ReadShort();
            var limit = reader.ReadUShort();
            socialGroups = new Types.AbstractSocialGroupInfos[limit];
            for (int i = 0; i < limit; i++)
            {
                 (socialGroups as Types.AbstractSocialGroupInfos[])[i] = ProtocolTypeManager.GetInstance<Types.AbstractSocialGroupInfos>(reader.ReadUShort());
                 (socialGroups as Types.AbstractSocialGroupInfos[])[i].Deserialize(reader);
            }
            playerState = reader.ReadSByte();
        }
        
    }
    
}