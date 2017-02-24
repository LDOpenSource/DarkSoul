

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayArenaSwitchToGameServerMessage : NetworkMessage
    {
        public override ushort Id => 6574;
        
        
        public bool validToken;
        public IEnumerable<sbyte> ticket;
        public short homeServerId;
        
        public GameRolePlayArenaSwitchToGameServerMessage()
        {
        }
        
        public GameRolePlayArenaSwitchToGameServerMessage(bool validToken, IEnumerable<sbyte> ticket, short homeServerId)
        {
            this.validToken = validToken;
            this.ticket = ticket;
            this.homeServerId = homeServerId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(validToken);
            writer.WriteVarInt((int)ticket.Count());
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
            writer.WriteShort(homeServerId);
        }
        
        public override void Deserialize(IReader reader)
        {
            validToken = reader.ReadBoolean();
            var limit = reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ticket as sbyte[])[i] = reader.ReadSByte();
            }
            homeServerId = reader.ReadShort();
        }
        
    }
    
}