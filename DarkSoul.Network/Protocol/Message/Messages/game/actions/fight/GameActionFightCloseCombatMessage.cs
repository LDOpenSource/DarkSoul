

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightCloseCombatMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        public override ushort Id => 6116;
        
        
        public ushort weaponGenericId;
        
        public GameActionFightCloseCombatMessage()
        {
        }
        
        public GameActionFightCloseCombatMessage(ushort actionId, double sourceId, bool silentCast, bool verboseCast, double targetId, short destinationCellId, sbyte critical, ushort weaponGenericId)
         : base(actionId, sourceId, silentCast, verboseCast, targetId, destinationCellId, critical)
        {
            this.weaponGenericId = weaponGenericId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)weaponGenericId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            weaponGenericId = reader.ReadVarUhShort();
        }
        
    }
    
}