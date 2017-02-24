

// Generated on 02/23/2017 18:06:38
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class CharacterBaseCharacteristic
    {
        public virtual short TypeId => 4;
        
        public short @base;
        public short additionnal;
        public short objectsAndMountBonus;
        public short alignGiftBonus;
        public short contextModif;
        
        public CharacterBaseCharacteristic()
        {
        }
        
        public CharacterBaseCharacteristic(short @base, short additionnal, short objectsAndMountBonus, short alignGiftBonus, short contextModif)
        {
            this.@base = @base;
            this.additionnal = additionnal;
            this.objectsAndMountBonus = objectsAndMountBonus;
            this.alignGiftBonus = alignGiftBonus;
            this.contextModif = contextModif;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)@base);
            writer.WriteVarShort((int)additionnal);
            writer.WriteVarShort((int)objectsAndMountBonus);
            writer.WriteVarShort((int)alignGiftBonus);
            writer.WriteVarShort((int)contextModif);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            @base = reader.ReadVarShort();
            additionnal = reader.ReadVarShort();
            objectsAndMountBonus = reader.ReadVarShort();
            alignGiftBonus = reader.ReadVarShort();
            contextModif = reader.ReadVarShort();
        }
        
    }
    
}