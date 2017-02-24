

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightRemoveTeamMemberMessage : NetworkMessage
    {
        public override ushort Id => 711;
        
        
        public short fightId;
        public sbyte teamId;
        public double charId;
        
        public GameFightRemoveTeamMemberMessage()
        {
        }
        
        public GameFightRemoveTeamMemberMessage(short fightId, sbyte teamId, double charId)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.charId = charId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(fightId);
            writer.WriteSByte(teamId);
            writer.WriteDouble(charId);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadShort();
            teamId = reader.ReadSByte();
            charId = reader.ReadDouble();
        }
        
    }
    
}