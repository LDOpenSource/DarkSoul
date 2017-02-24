

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SelectedServerDataMessage : NetworkMessage
    {
        public override ushort Id => 42;
        
        
        public ushort serverId;
        public string address;
        public ushort port;
        public bool canCreateNewCharacter;
        public IEnumerable<sbyte> ticket;
        
        public SelectedServerDataMessage()
        {
        }
        
        public SelectedServerDataMessage(ushort serverId, string address, ushort port, bool canCreateNewCharacter, IEnumerable<sbyte> ticket)
        {
            this.serverId = serverId;
            this.address = address;
            this.port = port;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.ticket = ticket;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)serverId);
            writer.WriteUTF(address);
            writer.WriteUShort(port);
            writer.WriteBoolean(canCreateNewCharacter);
            writer.WriteVarInt((int)ticket.Count());
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            serverId = reader.ReadVarUhShort();
            address = reader.ReadUTF();
            port = reader.ReadUShort();
            canCreateNewCharacter = reader.ReadBoolean();
            var limit = reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ticket as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}