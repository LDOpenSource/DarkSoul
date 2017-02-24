

// Generated on 02/23/2017 16:53:26
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterLevelUpInformationMessage : CharacterLevelUpMessage
    {
        public override ushort Id => 6076;
        
        
        public string name;
        public double id;
        
        public CharacterLevelUpInformationMessage()
        {
        }
        
        public CharacterLevelUpInformationMessage(byte newLevel, string name, double id)
         : base(newLevel)
        {
            this.name = name;
            this.id = id;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            name = reader.ReadUTF();
            id = reader.ReadVarUhLong();
        }
        
    }
    
}