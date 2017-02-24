

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DownloadSetSpeedRequestMessage : NetworkMessage
    {
        public override ushort Id => 1512;
        
        
        public sbyte downloadSpeed;
        
        public DownloadSetSpeedRequestMessage()
        {
        }
        
        public DownloadSetSpeedRequestMessage(sbyte downloadSpeed)
        {
            this.downloadSpeed = downloadSpeed;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(downloadSpeed);
        }
        
        public override void Deserialize(IReader reader)
        {
            downloadSpeed = reader.ReadSByte();
        }
        
    }
    
}