

// Generated on 02/23/2017 16:54:03
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ContactLookMessage : NetworkMessage
    {
        public override ushort Id => 5934;
        
        
        public uint requestId;
        public string playerName;
        public double playerId;
        public Types.EntityLook look;
        
        public ContactLookMessage()
        {
        }
        
        public ContactLookMessage(uint requestId, string playerName, double playerId, Types.EntityLook look)
        {
            this.requestId = requestId;
            this.playerName = playerName;
            this.playerId = playerId;
            this.look = look;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)requestId);
            writer.WriteUTF(playerName);
            writer.WriteVarLong(playerId);
            look.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            requestId = reader.ReadVarUhInt();
            playerName = reader.ReadUTF();
            playerId = reader.ReadVarUhLong();
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}