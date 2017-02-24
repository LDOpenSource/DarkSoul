

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionFollowers : HumanOption
    {
        public override short TypeId => 410;
        
        public IEnumerable<Types.IndexedEntityLook> followingCharactersLook;
        
        public HumanOptionFollowers()
        {
        }
        
        public HumanOptionFollowers(IEnumerable<Types.IndexedEntityLook> followingCharactersLook)
        {
            this.followingCharactersLook = followingCharactersLook;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)followingCharactersLook.Count());
            foreach (var entry in followingCharactersLook)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            var limit = reader.ReadUShort();
            followingCharactersLook = new Types.IndexedEntityLook[limit];
            for (int i = 0; i < limit; i++)
            {
                 (followingCharactersLook as Types.IndexedEntityLook[])[i] = new Types.IndexedEntityLook();
                 (followingCharactersLook as Types.IndexedEntityLook[])[i].Deserialize(reader);
            }
        }
        
    }
    
}