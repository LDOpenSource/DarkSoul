

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
    {
        public override ushort Id => 5731;
        
        
        public double targetId;
        public short targetCellId;
        public bool friendly;
        
        public GameRolePlayPlayerFightRequestMessage()
        {
        }
        
        public GameRolePlayPlayerFightRequestMessage(double targetId, short targetCellId, bool friendly)
        {
            this.targetId = targetId;
            this.targetCellId = targetCellId;
            this.friendly = friendly;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(targetId);
            writer.WriteShort(targetCellId);
            writer.WriteBoolean(friendly);
        }
        
        public override void Deserialize(IReader reader)
        {
            targetId = reader.ReadVarUhLong();
            targetCellId = reader.ReadShort();
            friendly = reader.ReadBoolean();
        }
        
    }
    
}