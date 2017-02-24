

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
    public class IdolSelectedMessage : NetworkMessage
    {
        public override ushort Id => 6581;
        
        
        public bool activate;
        public bool party;
        public ushort idolId;
        
        public IdolSelectedMessage()
        {
        }
        
        public IdolSelectedMessage(bool activate, bool party, ushort idolId)
        {
            this.activate = activate;
            this.party = party;
            this.idolId = idolId;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, activate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, party);
            writer.WriteByte(flag1);
            writer.WriteVarShort((int)idolId);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            activate = BooleanByteWrapper.GetFlag(flag1, 0);
            party = BooleanByteWrapper.GetFlag(flag1, 1);
            idolId = reader.ReadVarUhShort();
        }
        
    }
    
}