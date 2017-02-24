

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
    public class DareInformationsMessage : NetworkMessage
    {
        public override ushort Id => 0x1A00;
        
        
        public Types.DareInformations dareFixedInfos;
        public Types.DareVersatileInformations dareVersatilesInfos;
        
        public DareInformationsMessage()
        {
        }
        
        public DareInformationsMessage(Types.DareInformations dareFixedInfos, Types.DareVersatileInformations dareVersatilesInfos)
        {
            this.dareFixedInfos = dareFixedInfos;
            this.dareVersatilesInfos = dareVersatilesInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            dareFixedInfos.Serialize(writer);
            dareVersatilesInfos.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            dareFixedInfos = new Types.DareInformations();
            dareFixedInfos.Deserialize(reader);
            dareVersatilesInfos = new Types.DareVersatileInformations();
            dareVersatilesInfos.Deserialize(reader);
        }
        
    }
    
}