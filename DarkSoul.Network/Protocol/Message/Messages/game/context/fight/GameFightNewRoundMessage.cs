

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightNewRoundMessage : NetworkMessage
    {
        public override ushort Id => 6239;
        
        
        public uint roundNumber;
        
        public GameFightNewRoundMessage()
        {
        }
        
        public GameFightNewRoundMessage(uint roundNumber)
        {
            this.roundNumber = roundNumber;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)roundNumber);
        }
        
        public override void Deserialize(IReader reader)
        {
            roundNumber = reader.ReadVarUhInt();
        }
        
    }
    
}