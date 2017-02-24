

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterSpellModification
    {
        public virtual short TypeId => 215;
        
        public sbyte modificationType;
        public ushort spellId;
        public Types.CharacterBaseCharacteristic value;
        
        public CharacterSpellModification()
        {
        }
        
        public CharacterSpellModification(sbyte modificationType, ushort spellId, Types.CharacterBaseCharacteristic value)
        {
            this.modificationType = modificationType;
            this.spellId = spellId;
            this.value = value;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(modificationType);
            writer.WriteVarShort((int)spellId);
            value.Serialize(writer);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            modificationType = reader.ReadSByte();
            spellId = reader.ReadVarUhShort();
            value = new Types.CharacterBaseCharacteristic();
            value.Deserialize(reader);
        }
        
    }
    
}