

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlaySpellAnimMessage : NetworkMessage
    {
        public override ushort Id => 6114;
        
        
        public double casterId;
        public ushort targetCellId;
        public ushort spellId;
        public short spellLevel;
        
        public GameRolePlaySpellAnimMessage()
        {
        }
        
        public GameRolePlaySpellAnimMessage(double casterId, ushort targetCellId, ushort spellId, short spellLevel)
        {
            this.casterId = casterId;
            this.targetCellId = targetCellId;
            this.spellId = spellId;
            this.spellLevel = spellLevel;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(casterId);
            writer.WriteVarShort((int)targetCellId);
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(spellLevel);
        }
        
        public override void Deserialize(IReader reader)
        {
            casterId = reader.ReadVarUhLong();
            targetCellId = reader.ReadVarUhShort();
            spellId = reader.ReadVarUhShort();
            spellLevel = reader.ReadShort();
        }
        
    }
    
}