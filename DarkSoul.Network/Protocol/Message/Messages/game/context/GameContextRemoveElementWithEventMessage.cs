

// Generated on 02/23/2017 16:53:28
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
    {
        public override ushort Id => 6412;
        
        
        public sbyte elementEventId;
        
        public GameContextRemoveElementWithEventMessage()
        {
        }
        
        public GameContextRemoveElementWithEventMessage(double id, sbyte elementEventId)
         : base(id)
        {
            this.elementEventId = elementEventId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(elementEventId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            elementEventId = reader.ReadSByte();
        }
        
    }
    
}