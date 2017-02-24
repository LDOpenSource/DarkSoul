

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayPlayerLifeStatusMessage : NetworkMessage
    {
        public override ushort Id => 5996;
        
        
        public sbyte state;
        public int phenixMapId;
        
        public GameRolePlayPlayerLifeStatusMessage()
        {
        }
        
        public GameRolePlayPlayerLifeStatusMessage(sbyte state, int phenixMapId)
        {
            this.state = state;
            this.phenixMapId = phenixMapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(state);
            writer.WriteInt(phenixMapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            state = reader.ReadSByte();
            phenixMapId = reader.ReadInt();
        }
        
    }
    
}