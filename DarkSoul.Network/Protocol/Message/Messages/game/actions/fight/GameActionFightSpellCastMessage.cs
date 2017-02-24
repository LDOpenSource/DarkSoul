

// Generated on 02/23/2017 16:53:20
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        public override ushort Id => 1010;
        
        
        public ushort spellId;
        public short spellLevel;
        public IEnumerable<short> portalsIds;
        
        public GameActionFightSpellCastMessage()
        {
        }
        
        public GameActionFightSpellCastMessage(ushort actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, ushort spellId, short spellLevel, IEnumerable<short> portalsIds)
         : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.portalsIds = portalsIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)spellId);
            writer.WriteShort(spellLevel);
            writer.WriteShort((short)portalsIds.Count());
            foreach (var entry in portalsIds)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            spellLevel = reader.ReadShort();
            var limit = reader.ReadUShort();
            portalsIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (portalsIds as short[])[i] = reader.ReadShort();
            }
        }
        
    }
    
}