

// Generated on 02/23/2017 16:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyNameSetErrorMessage : AbstractPartyMessage
    {
        public override ushort Id => 6501;
        
        
        public sbyte result;
        
        public PartyNameSetErrorMessage()
        {
        }
        
        public PartyNameSetErrorMessage(uint partyId, sbyte result)
         : base(partyId)
        {
            this.result = result;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(result);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            result = reader.ReadSByte();
        }
        
    }
    
}