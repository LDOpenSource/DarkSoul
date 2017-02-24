

// Generated on 02/23/2017 16:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PlayerStatusUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6386;
        
        
        public int accountId;
        public double playerId;
        public Types.PlayerStatus status;
        
        public PlayerStatusUpdateMessage()
        {
        }
        
        public PlayerStatusUpdateMessage(int accountId, double playerId, Types.PlayerStatus status)
        {
            this.accountId = accountId;
            this.playerId = playerId;
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(accountId);
            writer.WriteVarLong(playerId);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            accountId = reader.ReadInt();
            playerId = reader.ReadVarUhLong();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
        }
        
    }
    
}