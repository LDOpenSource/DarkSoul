

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
    public class GameFightNewWaveMessage : NetworkMessage
    {
        public override ushort Id => 6490;
        
        
        public sbyte id;
        public sbyte teamId;
        public short nbTurnBeforeNextWave;
        
        public GameFightNewWaveMessage()
        {
        }
        
        public GameFightNewWaveMessage(sbyte id, sbyte teamId, short nbTurnBeforeNextWave)
        {
            this.id = id;
            this.teamId = teamId;
            this.nbTurnBeforeNextWave = nbTurnBeforeNextWave;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(id);
            writer.WriteSByte(teamId);
            writer.WriteShort(nbTurnBeforeNextWave);
        }
        
        public override void Deserialize(IReader reader)
        {
            id = reader.ReadSByte();
            teamId = reader.ReadSByte();
            nbTurnBeforeNextWave = reader.ReadShort();
        }
        
    }
    
}