

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ShortcutObjectItem : ShortcutObject
    {
        public override short TypeId => 371;
        
        public int itemUID;
        public int itemGID;
        
        public ShortcutObjectItem()
        {
        }
        
        public ShortcutObjectItem(sbyte slot, int itemUID, int itemGID)
         : base(slot)
        {
            this.itemUID = itemUID;
            this.itemGID = itemGID;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(itemUID);
            writer.WriteInt(itemGID);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            itemUID = reader.ReadInt();
            itemGID = reader.ReadInt();
        }
        
    }
    
}