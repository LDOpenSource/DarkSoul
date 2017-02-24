

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
    public class GameActionFightCastOnTargetRequestMessage : NetworkMessage
    {
        public override ushort Id => 6330;
        
        
        public ushort spellId;
        public double targetId;
        
        public GameActionFightCastOnTargetRequestMessage()
        {
        }
        
        public GameActionFightCastOnTargetRequestMessage(ushort spellId, double targetId)
        {
            this.spellId = spellId;
            this.targetId = targetId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)spellId);
            writer.WriteDouble(targetId);
        }
        
        public override void Deserialize(IReader reader)
        {
            spellId = reader.ReadVarUhShort();
            targetId = reader.ReadDouble();
        }
        
    }
    
}