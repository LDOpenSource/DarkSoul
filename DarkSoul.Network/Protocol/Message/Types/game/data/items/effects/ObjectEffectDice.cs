

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectDice : ObjectEffect
    {
        public override short TypeId => 73;
        
        public ushort diceNum;
        public ushort diceSide;
        public ushort diceConst;
        
        public ObjectEffectDice()
        {
        }
        
        public ObjectEffectDice(ushort actionId, ushort diceNum, ushort diceSide, ushort diceConst)
         : base(actionId)
        {
            this.diceNum = diceNum;
            this.diceSide = diceSide;
            this.diceConst = diceConst;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)diceNum);
            writer.WriteVarShort((int)diceSide);
            writer.WriteVarShort((int)diceConst);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            diceNum = reader.ReadVarUhShort();
            diceSide = reader.ReadVarUhShort();
            diceConst = reader.ReadVarUhShort();
        }
        
    }
    
}