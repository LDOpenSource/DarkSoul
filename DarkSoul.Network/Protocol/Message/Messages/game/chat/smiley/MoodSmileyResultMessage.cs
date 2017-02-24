

// Generated on 02/23/2017 16:53:27
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MoodSmileyResultMessage : NetworkMessage
    {
        public override ushort Id => 6196;
        
        
        public sbyte resultCode;
        public ushort smileyId;
        
        public MoodSmileyResultMessage()
        {
        }
        
        public MoodSmileyResultMessage(sbyte resultCode, ushort smileyId)
        {
            this.resultCode = resultCode;
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(resultCode);
            writer.WriteVarShort((int)smileyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            resultCode = reader.ReadSByte();
            smileyId = reader.ReadVarUhShort();
        }
        
    }
    
}