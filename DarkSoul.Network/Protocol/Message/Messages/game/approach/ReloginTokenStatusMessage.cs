

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
    public class ReloginTokenStatusMessage : NetworkMessage
    {
        public override ushort Id => 6539;
        
        
        public bool validToken;
        public IEnumerable<sbyte> ticket;
        
        public ReloginTokenStatusMessage()
        {
        }
        
        public ReloginTokenStatusMessage(bool validToken, IEnumerable<sbyte> ticket)
        {
            this.validToken = validToken;
            this.ticket = ticket;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(validToken);
            writer.WriteVarInt((int)ticket.Count());
            foreach (var entry in ticket)
            {
                 writer.WriteSByte(entry);
            }
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
        }
        
    }
    
}