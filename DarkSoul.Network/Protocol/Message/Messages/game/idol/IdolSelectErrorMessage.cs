

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolSelectErrorMessage : NetworkMessage
    {
        public override ushort Id => 6584;
        
        
        public bool activate;
        public bool party;
        public sbyte reason;
        public ushort idolId;
        
        public IdolSelectErrorMessage()
        {
        }
        
        public IdolSelectErrorMessage(bool activate, bool party, sbyte reason, ushort idolId)
        {
            this.activate = activate;
            this.party = party;
            this.reason = reason;
            this.idolId = idolId;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteSByte(reason);
            writer.WriteVarShort((int)idolId);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            reason = reader.ReadSByte();
            idolId = reader.ReadVarUhShort();
        }
        
    }
    
}