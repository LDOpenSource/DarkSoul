

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
    public class SelectedServerRefusedMessage : NetworkMessage
    {
        public override ushort Id => 41;
        
        
        public ushort serverId;
        public sbyte error;
        public sbyte serverStatus;
        
        public SelectedServerRefusedMessage()
        {
        }
        
        public SelectedServerRefusedMessage(ushort serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)serverId);
            writer.WriteSByte(error);
            writer.WriteSByte(serverStatus);
        }
        
        public override void Deserialize(IReader reader)
        {
            serverId = reader.ReadVarUhShort();
            error = reader.ReadSByte();
            serverStatus = reader.ReadSByte();
        }
        
    }
    
}