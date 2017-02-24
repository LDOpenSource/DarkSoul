

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildInvitedMessage : NetworkMessage
    {
        public override ushort Id => 5552;
        
        
        public double recruterId;
        public string recruterName;
        public Types.BasicGuildInformations guildInfo;
        
        public GuildInvitedMessage()
        {
        }
        
        public GuildInvitedMessage(double recruterId, string recruterName, Types.BasicGuildInformations guildInfo)
        {
            this.recruterId = recruterId;
            this.recruterName = recruterName;
            this.guildInfo = guildInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(recruterId);
            writer.WriteUTF(recruterName);
            guildInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            recruterId = reader.ReadVarUhLong();
            recruterName = reader.ReadUTF();
            guildInfo = new Types.BasicGuildInformations();
            guildInfo.Deserialize(reader);
        }
        
    }
    
}