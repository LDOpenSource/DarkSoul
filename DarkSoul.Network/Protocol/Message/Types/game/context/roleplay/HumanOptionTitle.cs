

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HumanOptionTitle : HumanOption
    {
        public override short TypeId => 408;
        
        public ushort titleId;
        public string titleParam;
        
        public HumanOptionTitle()
        {
        }
        
        public HumanOptionTitle(ushort titleId, string titleParam)
        {
            this.titleId = titleId;
            this.titleParam = titleParam;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)titleId);
            writer.WriteUTF(titleParam);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            titleId = reader.ReadVarUhShort();
            titleParam = reader.ReadUTF();
        }
        
    }
    
}