

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameMapMovementMessage : NetworkMessage
    {
        public override ushort Id => 951;
        
        
        public IEnumerable<short> keyMovements;
        public short forcedDirection;
        public double actorId;
        
        public GameMapMovementMessage()
        {
        }
        
        public GameMapMovementMessage(IEnumerable<short> keyMovements, short forcedDirection, double actorId)
        {
            this.keyMovements = keyMovements;
            this.forcedDirection = forcedDirection;
            this.actorId = actorId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)keyMovements.Count());
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteShort(forcedDirection);
            writer.WriteDouble(actorId);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (keyMovements as short[])[i] = reader.ReadShort();
            }
            forcedDirection = reader.ReadShort();
            actorId = reader.ReadDouble();
        }
        
    }
    
}