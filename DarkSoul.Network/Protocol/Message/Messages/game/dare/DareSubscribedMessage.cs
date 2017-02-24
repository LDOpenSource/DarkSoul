

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
    public class DareSubscribedMessage : NetworkMessage
    {
        public override ushort Id => 6660;
        
        
        public bool success;
        public bool subscribe;
        public double dareId;
        public Types.DareVersatileInformations dareVersatilesInfos;
        
        public DareSubscribedMessage()
        {
        }
        
        public DareSubscribedMessage(bool success, bool subscribe, double dareId, Types.DareVersatileInformations dareVersatilesInfos)
        {
            this.success = success;
            this.subscribe = subscribe;
            this.dareId = dareId;
            this.dareVersatilesInfos = dareVersatilesInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, subscribe);
            writer.WriteByte(flag1);
            writer.WriteDouble(dareId);
            dareVersatilesInfos.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            subscribe = BooleanByteWrapper.GetFlag(flag1, 1);
            dareId = reader.ReadDouble();
            dareVersatilesInfos = new Types.DareVersatileInformations();
            dareVersatilesInfos.Deserialize(reader);
        }
        
    }
    
}