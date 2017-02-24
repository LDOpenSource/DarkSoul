

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceJoinedMessage : NetworkMessage
    {
        public override ushort Id => 6402;
        
        
        public Types.AllianceInformations allianceInfo;
        public bool enabled;
        public uint leadingGuildId;
        
        public AllianceJoinedMessage()
        {
        }
        
        public AllianceJoinedMessage(Types.AllianceInformations allianceInfo, bool enabled, uint leadingGuildId)
        {
            this.allianceInfo = allianceInfo;
            this.enabled = enabled;
            this.leadingGuildId = leadingGuildId;
        }
        
        public override void Serialize(IWriter writer)
        {
            allianceInfo.Serialize(writer);
            writer.WriteBoolean(enabled);
            writer.WriteVarInt((int)leadingGuildId);
        }
        
        public override void Deserialize(IReader reader)
        {
            allianceInfo = new Types.AllianceInformations();
            allianceInfo.Deserialize(reader);
            enabled = reader.ReadBoolean();
            leadingGuildId = reader.ReadVarUhInt();
        }
        
    }
    
}