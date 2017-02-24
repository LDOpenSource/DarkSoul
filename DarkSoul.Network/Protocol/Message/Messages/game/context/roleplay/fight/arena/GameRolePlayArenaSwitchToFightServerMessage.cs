

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
    public class GameRolePlayArenaSwitchToFightServerMessage : NetworkMessage
    {
        public override ushort Id => 6575;
        
        
        public string address;
        public ushort port;
        public IEnumerable<sbyte> ticket;
        
        public GameRolePlayArenaSwitchToFightServerMessage()
        {
        }
        
        public GameRolePlayArenaSwitchToFightServerMessage(string address, ushort port, IEnumerable<sbyte> ticket)
        {
            this.address = address;
            this.port = port;
            this.ticket = ticket;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteUTF(address);
            writer.WriteUShort(port);
            writer.WriteVarInt((int)ticket.Count());
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            address = reader.ReadUTF();
            port = reader.ReadUShort();
            var limit = reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ticket as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}