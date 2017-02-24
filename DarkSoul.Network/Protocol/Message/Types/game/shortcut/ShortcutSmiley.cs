

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ShortcutSmiley : Shortcut
    {
        public override short TypeId => 388;
        
        public ushort smileyId;
        
        public ShortcutSmiley()
        {
        }
        
        public ShortcutSmiley(sbyte slot, ushort smileyId)
         : base(slot)
        {
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)smileyId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            smileyId = reader.ReadVarUhShort();
        }
        
    }
    
}