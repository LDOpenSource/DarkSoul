

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockItem : ObjectItemInRolePlay
    {
        public override short TypeId => 185;
        
        public Types.ItemDurability durability;
        
        public PaddockItem()
        {
        }
        
        public PaddockItem(ushort cellId, ushort objectGID, Types.ItemDurability durability)
         : base(cellId, objectGID)
        {
            this.durability = durability;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            durability.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            durability = new Types.ItemDurability();
            durability.Deserialize(reader);
        }
        
    }
    
}