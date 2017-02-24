

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterLightInformations
    {
        public virtual short TypeId => 413;
        
        public bool sex;
        public bool alive;
        public double id;
        public sbyte wave;
        public ushort level;
        public sbyte breed;
        
        public GameFightFighterLightInformations()
        {
        }
        
        public GameFightFighterLightInformations(bool sex, bool alive, double id, sbyte wave, ushort level, sbyte breed)
        {
            this.sex = sex;
            this.alive = alive;
            this.id = id;
            this.wave = wave;
            this.level = level;
            this.breed = breed;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, sex);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, alive);
            writer.WriteByte(flag1);
            writer.WriteDouble(id);
            writer.WriteSByte(wave);
            writer.WriteVarShort((int)level);
            writer.WriteSByte(breed);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            sex = BooleanByteWrapper.GetFlag(flag1, 0);
            alive = BooleanByteWrapper.GetFlag(flag1, 1);
            id = reader.ReadDouble();
            wave = reader.ReadSByte();
            level = reader.ReadVarUhShort();
            breed = reader.ReadSByte();
        }
        
    }
    
}