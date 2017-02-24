

// Generated on 02/23/2017 16:54:00
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolsPresetUseResultMessage : NetworkMessage
    {
        public override ushort Id => 6614;
        
        
        public sbyte presetId;
        public sbyte code;
        public IEnumerable<ushort> missingIdols;
        
        public IdolsPresetUseResultMessage()
        {
        }
        
        public IdolsPresetUseResultMessage(sbyte presetId, sbyte code, IEnumerable<ushort> missingIdols)
        {
            this.presetId = presetId;
            this.code = code;
            this.missingIdols = missingIdols;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            writer.WriteShort((short)missingIdols.Count());
            foreach (var entry in missingIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            presetId = reader.ReadSByte();
            code = reader.ReadSByte();
            var limit = reader.ReadUShort();
            missingIdols = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (missingIdols as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}