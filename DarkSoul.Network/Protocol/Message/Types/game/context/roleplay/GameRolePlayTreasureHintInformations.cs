

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayTreasureHintInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 471;
        
        public ushort npcId;
        
        public GameRolePlayTreasureHintInformations()
        {
        }
        
        public GameRolePlayTreasureHintInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId)
         : base(contextualId, look, disposition)
        {
            this.npcId = npcId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)npcId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
        }
        
    }
    
}