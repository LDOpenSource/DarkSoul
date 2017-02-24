

// Generated on 02/23/2017 18:06:47
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class StartupActionAddObject
    {
        public virtual short TypeId => 52;
        
        public int uid;
        public string title;
        public string text;
        public string descUrl;
        public string pictureUrl;
        public IEnumerable<Types.ObjectItemInformationWithQuantity> items;
        
        public StartupActionAddObject()
        {
        }
        
        public StartupActionAddObject(int uid, string title, string text, string descUrl, string pictureUrl, IEnumerable<Types.ObjectItemInformationWithQuantity> items)
        {
            this.uid = uid;
            this.title = title;
            this.text = text;
            this.descUrl = descUrl;
            this.pictureUrl = pictureUrl;
            this.items = items;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteInt(uid);
            writer.WriteUTF(title);
            writer.WriteUTF(text);
            writer.WriteUTF(descUrl);
            writer.WriteUTF(pictureUrl);
            writer.WriteShort((short)items.Count());
            foreach (var entry in items)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            uid = reader.ReadInt();
            title = reader.ReadUTF();
            text = reader.ReadUTF();
            descUrl = reader.ReadUTF();
            pictureUrl = reader.ReadUTF();
            var limit = reader.ReadUShort();
            items = new Types.ObjectItemInformationWithQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 (items as Types.ObjectItemInformationWithQuantity[])[i] = new Types.ObjectItemInformationWithQuantity();
                 (items as Types.ObjectItemInformationWithQuantity[])[i].Deserialize(reader);
            }
        }
        
    }
    
}