

// Generated on 02/23/2017 18:06:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameRolePlayNpcInformations : GameRolePlayActorInformations
    {
        public override short TypeId => 156;
        
        public ushort npcId;
        public bool sex;
        public ushort specialArtworkId;
        
        public GameRolePlayNpcInformations()
        {
        }
        
        public GameRolePlayNpcInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, ushort npcId, bool sex, ushort specialArtworkId)
         : base(contextualId, look, disposition)
        {
            this.npcId = npcId;
            this.sex = sex;
            this.specialArtworkId = specialArtworkId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)npcId);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)specialArtworkId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            npcId = reader.ReadVarUhShort();
            sex = reader.ReadBoolean();
            specialArtworkId = reader.ReadVarUhShort();
        }
        
    }
    
}