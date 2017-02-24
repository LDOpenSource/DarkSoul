

// Generated on 02/23/2017 16:53:23
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ServerSettingsMessage : NetworkMessage
    {
        public override ushort Id => 6340;
        
        
        public string lang;
        public sbyte community;
        public sbyte gameType;
        public ushort arenaLeaveBanTime;
        
        public ServerSettingsMessage()
        {
        }
        
        public ServerSettingsMessage(string lang, sbyte community, sbyte gameType, ushort arenaLeaveBanTime)
        {
            this.lang = lang;
            this.community = community;
            this.gameType = gameType;
            this.arenaLeaveBanTime = arenaLeaveBanTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(lang);
            writer.WriteSByte(community);
            writer.WriteSByte(gameType);
            writer.WriteVarShort((int)arenaLeaveBanTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            lang = reader.ReadUTF();
            community = reader.ReadSByte();
            gameType = reader.ReadSByte();
            arenaLeaveBanTime = reader.ReadVarUhShort();
        }
        
    }
    
}