

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
    public class GameFightOptionStateUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5927;
        
        
        public short fightId;
        public sbyte teamId;
        public sbyte option;
        public bool state;
        
        public GameFightOptionStateUpdateMessage()
        {
        }
        
        public GameFightOptionStateUpdateMessage(short fightId, sbyte teamId, sbyte option, bool state)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.option = option;
            this.state = state;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(fightId);
            writer.WriteSByte(teamId);
            writer.WriteSByte(option);
            writer.WriteBoolean(state);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadShort();
            teamId = reader.ReadSByte();
            option = reader.ReadSByte();
            state = reader.ReadBoolean();
        }
        
    }
    
}