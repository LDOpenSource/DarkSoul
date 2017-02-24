

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareCreatedMessage : NetworkMessage
    {
        public override ushort Id => 6668;
        
        
        public Types.DareInformations dareInfos;
        public bool needNotifications;
        
        public DareCreatedMessage()
        {
        }
        
        public DareCreatedMessage(Types.DareInformations dareInfos, bool needNotifications)
        {
            this.dareInfos = dareInfos;
            this.needNotifications = needNotifications;
        }
        
        public override void Serialize(IWriter writer)
        {
            dareInfos.Serialize(writer);
            writer.WriteBoolean(needNotifications);
        }
        
        public override void Deserialize(IReader reader)
        {
            dareInfos = new Types.DareInformations();
            dareInfos.Deserialize(reader);
            needNotifications = reader.ReadBoolean();
        }
        
    }
    
}