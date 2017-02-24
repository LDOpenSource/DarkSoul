

// Generated on 02/23/2017 16:53:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildChangeMemberParametersMessage : NetworkMessage
    {
        public override ushort Id => 5549;
        
        
        public double memberId;
        public ushort rank;
        public sbyte experienceGivenPercent;
        public uint rights;
        
        public GuildChangeMemberParametersMessage()
        {
        }
        
        public GuildChangeMemberParametersMessage(double memberId, ushort rank, sbyte experienceGivenPercent, uint rights)
        {
            this.memberId = memberId;
            this.rank = rank;
            this.experienceGivenPercent = experienceGivenPercent;
            this.rights = rights;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(memberId);
            writer.WriteVarShort((int)rank);
            writer.WriteSByte(experienceGivenPercent);
            writer.WriteVarInt((int)rights);
        }
        
        public override void Deserialize(IReader reader)
        {
            memberId = reader.ReadVarUhLong();
            rank = reader.ReadVarUhShort();
            experienceGivenPercent = reader.ReadSByte();
            rights = reader.ReadVarUhInt();
        }
        
    }
    
}