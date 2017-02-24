

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ShortcutEmote : Shortcut
    {
        public override short TypeId => 389;
        
        public byte emoteId;
        
        public ShortcutEmote()
        {
        }
        
        public ShortcutEmote(sbyte slot, byte emoteId)
         : base(slot)
        {
            this.emoteId = emoteId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(emoteId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            emoteId = reader.ReadByte();
        }
        
    }
    
}