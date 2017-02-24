

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class UpdateSelfAgressableStatusMessage : NetworkMessage
    {
        public override ushort Id => 6456;
        
        
        public sbyte status;
        public int probationTime;
        
        public UpdateSelfAgressableStatusMessage()
        {
        }
        
        public UpdateSelfAgressableStatusMessage(sbyte status, int probationTime)
        {
            this.status = status;
            this.probationTime = probationTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(status);
            writer.WriteInt(probationTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            status = reader.ReadSByte();
            probationTime = reader.ReadInt();
        }
        
    }
    
}