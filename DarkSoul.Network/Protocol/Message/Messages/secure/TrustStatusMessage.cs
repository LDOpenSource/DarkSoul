

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
    public class TrustStatusMessage : NetworkMessage
    {
        public override ushort Id => 6267;
        
        
        public bool trusted;
        public bool certified;
        
        public TrustStatusMessage()
        {
        }
        
        public TrustStatusMessage(bool trusted, bool certified)
        {
            this.trusted = trusted;
            this.certified = certified;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, trusted);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, certified);
            writer.WriteByte(flag1);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            trusted = BooleanByteWrapper.GetFlag(flag1, 0);
            certified = BooleanByteWrapper.GetFlag(flag1, 1);
        }
        
    }
    
}