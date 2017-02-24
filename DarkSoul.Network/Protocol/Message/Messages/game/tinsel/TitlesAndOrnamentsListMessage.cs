

// Generated on 02/23/2017 16:54:04
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TitlesAndOrnamentsListMessage : NetworkMessage
    {
        public override ushort Id => 6367;
        
        
        public IEnumerable<ushort> titles;
        public IEnumerable<ushort> ornaments;
        public ushort activeTitle;
        public ushort activeOrnament;
        
        public TitlesAndOrnamentsListMessage()
        {
        }
        
        public TitlesAndOrnamentsListMessage(IEnumerable<ushort> titles, IEnumerable<ushort> ornaments, ushort activeTitle, ushort activeOrnament)
        {
            this.titles = titles;
            this.ornaments = ornaments;
            this.activeTitle = activeTitle;
            this.activeOrnament = activeOrnament;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)titles.Count());
            foreach (var entry in titles)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)ornaments.Count());
            foreach (var entry in ornaments)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteVarShort((int)activeTitle);
            writer.WriteVarShort((int)activeOrnament);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            titles = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (titles as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            ornaments = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (ornaments as ushort[])[i] = reader.ReadVarUhShort();
            }
            activeTitle = reader.ReadVarUhShort();
            activeOrnament = reader.ReadVarUhShort();
        }
        
    }
    
}